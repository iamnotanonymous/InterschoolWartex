using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Productcontrol : MonoBehaviour
{
    public static int[] products = {0, 0, 0, 0, 0, 0, 0, 0 };
    public static string[] arangement = { "", "", "", "", "", "", "", "" };
    public static int i;
    public int a;

    public GameObject holnumitm;
    public GameObject holdernumitems;

    void Start()
    {
        products = Cart.productsc;
        arangement = Cart.listc;
        a = Cart.i2;
        up();
    }
    
    
    void up()
    {
        if (i > 0)
        {
            holdernumitems.SetActive(true);
            holnumitm.GetComponent<Text>().text = a.ToString();
        }
    }

    public void add1()
    {
        if (products[0] == 0)
        {
            arangement[i] = "ChocoVanila Cake";
            i = i + 1;
            products[0] = 1;
            a = a + 1;
            i = a;
            up();
        }
    }
    public void add2()
    {
        if (products[1] == 0)
        {
            arangement[i] = "Healthy Fruit cake";
            i = i + 1;
            products[1] = 1;
            a = a + 1;
            i = a;
            up();
        }
    }
    public void add3()
    {
        if (products[2] == 0)
        {
            arangement[i] = "CandyCorn Cake";
            i = i + 1;
            products[2] = 1;
            a = a + 1;
            i = a;
            up();
        }
    }
    public void add4()
    {
        if (products[3] == 0)
        {
            arangement[i] = "Oreo-Vanilla Cake";
            i = i + 1;
            products[3] = 1;
            a = a + 1;
            i = a;
            up();
        }
    }
    public void add5()
    {
        if (products[4] == 0)
        {
            arangement[i] = "Sprinkled Donuts";
            i = i + 1;
            products[4] = 1;
            a = a + 1;
            i = a;
            up();
        }
    }
    public void add6()
    {
        if (products[5] == 0)
        {
            arangement[i] = "ChocoFilled Pastries";
            i = i + 1;
            products[5] = 1;
            a = a + 1;
            i = a;
            up();
        }
    }
    public void add7()
    {
        if (products[6] == 0)
        {
            arangement[i] = "Fruit Pastries";
            i = i + 1;
            products[6] = 1;
            a = a + 1;
            i = a;
            up();
        }
    }
    public void add8()
    {
        if (products[7] == 0)
        {
            arangement[i] = "Sweet Buns";
            i = i + 1;
            products[7] = 1;
            a = a + 1;
            i = a;
            up();
        }
    }
}
