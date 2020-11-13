if (document.readyState == 'loading') {
    document.addEventListener('DOMContentLoaded', ready)
} else {
    ready()
}
var Limit = 0;
function ready() {
    var remcrtitems = document.getElementsByClassName('btn-danger')
    for (var i = 0; i < remcrtitems.length; i++) {
        var button = remcrtitems[i]
        button.addEventListener('click', remcartitem)
    }

    var quaninp = document.getElementsByClassName('cart-quantity-input')
    for (var i = 0; i < quaninp.length; i++) {
        var input = quaninp[i]
        input.addEventListener('change', quanchanged)
    }

    var addtocart = document.getElementsByClassName('shop-item-button')
    for (var i = 0; i < addtocart.length; i++) {
        var button = addtocart[i]
        button.addEventListener('click', addcartbutt)
    }

    document.getElementsByClassName('btn-purchase')[0].addEventListener('click', purbuttclick)
}

function purbuttclick() {
	alert(total)
    var cartItems = document.getElementsByClassName('cart-items')[0]
    while (cartItems.hasChildNodes()) {
        cartItems.removeChild(cartItems.firstChild)
    }
    updcarttot()
}

function remcartitem(event) {
	var buttonClicked = event.target
	var shopItemr = buttonClicked.parentElement.parentElement
	var title1 = shopItemr.getElementsByClassName('cart-item-title').innerText
    var indx = Items1.indexOf(title1);
	Items1.splice(indx,1);
	buttonClicked.parentElement.parentElement.remove()
	Limit = Limit - 1;
    updcarttot()
}

function quanchanged(event) {
    var input = event.target
    if (isNaN(input.value) || input.value <= 0) {
        input.value = 1
    }
    updcarttot()
}

function addcartbutt(event) {
    var button = event.target
    var shopItem = button.parentElement.parentElement
    var title = shopItem.getElementsByClassName('title')[0].innerText
    var price = shopItem.getElementsByClassName('price')[0].innerText
    additem(title, price)
    updcarttot()
}

var Items1 = [];

function additem(title, price) {
    var cartRow = document.createElement('div')
    cartRow.classList.add('cart-row')
    var cartItems = document.getElementsByClassName('cart-items')[0]
    var cartItemNames = cartItems.getElementsByClassName('cart-item-title')
    for (var i = 0; i < cartItemNames.length; i++) {
        if (cartItemNames[i].innerText == title) {
            alert('This item is already added to the cart')
            return
        }
    }
	Items1.push(title);
    var cartrcontent = `
        <div class="cart-item cart-column">
            <span class="cart-item-title">${title}</span>
        </div>
        <span class="cart-price cart-column">${price}</span>
        <div class="cart-quantity cart-column">
            <input class="cart-quantity-input" type="number" value="1">
            <button class="btn btn-danger" type="button">REMOVE</button>
        </div>`
	Limit = Limit + 1;
    cartRow.innerHTML = cartrcontent
    cartItems.append(cartRow)
    cartRow.getElementsByClassName('btn-danger')[0].addEventListener('click', remcartitem)
    cartRow.getElementsByClassName('cart-quantity-input')[0].addEventListener('change', quanchanged)
   
}

function updcarttot() {
    var cartItemcontain = document.getElementsByClassName('cart-items')[0]
    var cartRows = cartItemcontain.getElementsByClassName('cart-row')
    var total = 0
    for (var i = 0; i < cartRows.length; i++) {
        var cartRow = cartRows[i]
        var priceElement = cartRow.getElementsByClassName('cart-price')[0]
        var quantityElement = cartRow.getElementsByClassName('cart-quantity-input')[0]
        var price = parseFloat(priceElement.innerText.replace('$',''))
        var quantity = quantityElement.value
        total = total + (price * quantity)
    }
    total = Math.round(total * 100) / 100
	var t = '$' + total
    document.getElementsByClassName('cart-total-price')[0].innerText = t
	sessionStorage.setItem('total', t);
	sessionStorage.setItem('lim',Limit);
	sessionStorage.setItem('items',Items1);
}