using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Cart : MonoBehaviour
{
    public static int[] productsc = Productcontrol.products;
    public static string[] listc = Productcontrol.arangement;
    public static int i2;
    public int i3;
    public int k1;
    public int g;
    public static string[] Newlist = { "", "", "", "", "", "", "", ""};

    public float cnt = 0;

    public GameObject Value0;
    public GameObject Value1;
    public GameObject Value2;
    public GameObject Value3;
    public GameObject Value4;
    public GameObject Value5;
    public GameObject Value6;
    public GameObject Value7;
    public GameObject holder;

    public GameObject pValue0;
    public GameObject pValue1;
    public GameObject pValue2;
    public GameObject pValue3;
    public GameObject pValue4;
    public GameObject pValue5;
    public GameObject pValue6;
    public GameObject pValue7;
    
    
    public GameObject rValue0;
    public GameObject rValue1;
    public GameObject rValue2;
    public GameObject rValue3;
    public GameObject rValue4;
    public GameObject rValue5;
    public GameObject rValue6;
    public GameObject rValue7;


    void Start()
    {
        i2 = Productcontrol.i;
        for (int k = 0; k < 8; k++)
            {
                if (listc[k] == "")
                {
                }
                else
                {
                    if (cnt == 0)
                    {
                        pValue0.SetActive(true);
                        Value0.GetComponent<Text>().text = listc[k] + "   $30";
                        cnt = cnt + 1;
                    }
                    else if (cnt == 1)
                    {
                        pValue1.SetActive(true);
                        Value1.GetComponent<Text>().text = listc[k];
                        cnt = cnt + 1;
                    }
                    else if (cnt == 2)
                    {
                        pValue2.SetActive(true);
                        Value2.GetComponent<Text>().text = listc[k];
                        cnt = cnt + 1;
                    }
                    else if (cnt == 3)
                    {
                        pValue3.SetActive(true);
                        Value3.GetComponent<Text>().text = listc[k];
                        cnt = cnt + 1;
                    }
                    else if (cnt == 4)
                    {
                        pValue4.SetActive(true);
                        Value4.GetComponent<Text>().text = listc[k];
                        cnt = cnt + 1;
                    }
                    else if (cnt == 5)
                    {
                        pValue5.SetActive(true);
                        Value5.GetComponent<Text>().text = listc[k];
                        cnt = cnt + 1;
                    }else if (cnt == 5)
                    {
                        pValue5.SetActive(true);
                        Value5.GetComponent<Text>().text = listc[k];
                        cnt = cnt + 1;
                    }
                    else if (cnt == 6)
                    { 
                        pValue6.SetActive(true);
                        Value6.GetComponent<Text>().text = listc[k];
                        cnt = cnt + 1;
                    }
                    else if (cnt == 7)
                    {
                        pValue7.SetActive(true);
                        Value7.GetComponent<Text>().text = listc[k];
                        cnt = cnt + 1;
                    }
                }
            }
        }

    public void rembtn1()
    {
        int h = 0;
        k1 = 0;
        if (listc[h] == "ChocoVanila Cake")
        {
            productsc[0] = 0;
        }
        else if (listc[h] == "Healthy Fruit cake")
        {
            productsc[1] = 0;
        }
        else if (listc[h] == "CandyCorn Cake")
        {
            productsc[2] = 0;
        }
        else if (listc[h] == "Oreo-Vanilla Cake")
        {
            productsc[3] = 0;
        }
        else if (listc[h] == "Sprinkled Donuts")
        {
            productsc[4] = 0;
        }
        else if (listc[h] == "ChocoFilled Pastries")
        {
            productsc[5] = 0;
        }
        else if (listc[h] == "Fruit Pastries")
        {
            productsc[6] = 0;
        }
        else if (listc[h] == "Sweet Buns")
        {
            productsc[7] = 0;
        }
        listc[h] = "";
        for (int x = 0; x < 8; x++)
        {
            if (listc[x] == "")
            {
            }
            else if (listc[x] != "")
            {
                Newlist[k1] = listc[x];
                k1 = k1 + 1;
            }
        }
        g = 8 - k1;
        for (int x = 0; x < g; x++)
        {
            Newlist[k1] = "";
            k1 = k1 + 1;
        }
        i2 = i2 - 1;
        listc = Newlist;
        rValue0.SetActive(true);
    }
    public void rembtn2()
    {
        int h = 1;
        k1 = 0;
        if (listc[h] == "ChocoVanila Cake")
        {
            productsc[0] = 0;
        }
        else if (listc[h] == "Healthy Fruit cake")
        {
            productsc[1] = 0;
        }
        else if (listc[h] == "CandyCorn Cake")
        {
            productsc[2] = 0;
        }
        else if (listc[h] == "Oreo-Vanilla Cake")
        {
            productsc[3] = 0;
        }
        else if (listc[h] == "Sprinkled Donuts")
        {
            productsc[4] = 0;
        }
        else if (listc[h] == "ChocoFilled Pastries")
        {
            productsc[5] = 0;
        }
        else if (listc[h] == "Fruit Pastries")
        {
            productsc[6] = 0;
        }
        else if (listc[h] == "Sweet Buns")
        {
            productsc[7] = 0;
        }
        listc[h] = "";
        for (int x = 0; x < 8; x++)
        {
            if (listc[x] == "")
            {
            }
            else if (listc[x] != "")
            {
                Newlist[k1] = listc[x];
                k1 = k1 + 1;
            }
        }
        g = 8 - k1;
        for (int x = 0; x < g; x++)
        {
            Newlist[k1] = "";
            k1 = k1 + 1;
        }
        i2 = i2 - 1;
        listc = Newlist;
        rValue1.SetActive(true);
    }
    public void rembtn3()
    {
        int h = 2;
        k1 = 0;
        if (listc[h] == "ChocoVanila Cake")
        {
            productsc[0] = 0;
        }
        else if (listc[h] == "Healthy Fruit cake")
        {
            productsc[1] = 0;
        }
        else if (listc[h] == "CandyCorn Cake")
        {
            productsc[2] = 0;
        }
        else if (listc[h] == "Oreo-Vanilla Cake")
        {
            productsc[3] = 0;
        }
        else if (listc[h] == "Sprinkled Donuts")
        {
            productsc[4] = 0;
        }
        else if (listc[h] == "ChocoFilled Pastries")
        {
            productsc[5] = 0;
        }
        else if (listc[h] == "Fruit Pastries")
        {
            productsc[6] = 0;
        }
        else if (listc[h] == "Sweet Buns")
        {
            productsc[7] = 0;
        }
        listc[h] = "";
        for (int x = 0; x < 8; x++)
        {
            if (listc[x] == "")
            {
            }
            else if (listc[x] != "")
            {
                Newlist[k1] = listc[x];
                k1 = k1 + 1;
            }
        }
        g = 8 - k1;
        for (int x = 0; x < g; x++)
        {
            Newlist[k1] = "";
            k1 = k1 + 1;
        }
        i2 = i2 - 1;
        listc = Newlist;
        rValue2.SetActive(true);
    }
    public void rembtn4()
    {
        int h = 3;
        k1 = 0;
        if (listc[h] == "ChocoVanila Cake")
        {
            productsc[0] = 0;
        }
        else if (listc[h] == "Healthy Fruit cake")
        {
            productsc[1] = 0;
        }
        else if (listc[h] == "CandyCorn Cake")
        {
            productsc[2] = 0;
        }
        else if (listc[h] == "Oreo-Vanilla Cake")
        {
            productsc[3] = 0;
        }
        else if (listc[h] == "Sprinkled Donuts")
        {
            productsc[4] = 0;
        }
        else if (listc[h] == "ChocoFilled Pastries")
        {
            productsc[5] = 0;
        }
        else if (listc[h] == "Fruit Pastries")
        {
            productsc[6] = 0;
        }
        else if (listc[h] == "Sweet Buns")
        {
            productsc[7] = 0;
        }
        listc[h] = "";
        for (int x = 0; x < 8; x++)
        {
            if (listc[x] == "")
            {
            }
            else if (listc[x] != "")
            {
                Newlist[k1] = listc[x];
                k1 = k1 + 1;
            }
        }
        g = 8 - k1;
        for (int x = 0; x < g; x++)
        {
            Newlist[k1] = "";
            k1 = k1 + 1;
        }
        i2 = i2 - 1;
        listc = Newlist;
        rValue3.SetActive(true);
    }
    public void rembtn5()
    {
        int h = 4;
        k1 = 0;
        if (listc[h] == "ChocoVanila Cake")
        {
            productsc[0] = 0;
        }
        else if (listc[h] == "Healthy Fruit cake")
        {
            productsc[1] = 0;
        }
        else if (listc[h] == "CandyCorn Cake")
        {
            productsc[2] = 0;
        }
        else if (listc[h] == "Oreo-Vanilla Cake")
        {
            productsc[3] = 0;
        }
        else if (listc[h] == "Sprinkled Donuts")
        {
            productsc[4] = 0;
        }
        else if (listc[h] == "ChocoFilled Pastries")
        {
            productsc[5] = 0;
        }
        else if (listc[h] == "Fruit Pastries")
        {
            productsc[6] = 0;
        }
        else if (listc[h] == "Sweet Buns")
        {
            productsc[7] = 0;
        }
        listc[h] = "";
        for (int x = 0; x < 8; x++)
        {
            if (listc[x] == "")
            {
            }
            else if (listc[x] != "")
            {
                Newlist[k1] = listc[x];
                k1 = k1 + 1;
            }
        }
        g = 8 - k1;
        for (int x = 0; x < g; x++)
        {
            Newlist[k1] = "";
            k1 = k1 + 1;
        }
        i2 = i2 - 1;
        listc = Newlist;
        rValue4.SetActive(true);
    }
    public void rembtn6()
    {
        int h = 5;
        k1 = 0;
        if (listc[h] == "ChocoVanila Cake")
        {
            productsc[0] = 0;
        }
        else if (listc[h] == "Healthy Fruit cake")
        {
            productsc[1] = 0;
        }
        else if (listc[h] == "CandyCorn Cake")
        {
            productsc[2] = 0;
        }
        else if (listc[h] == "Oreo-Vanilla Cake")
        {
            productsc[3] = 0;
        }
        else if (listc[h] == "Sprinkled Donuts")
        {
            productsc[4] = 0;
        }
        else if (listc[h] == "ChocoFilled Pastries")
        {
            productsc[5] = 0;
        }
        else if (listc[h] == "Fruit Pastries")
        {
            productsc[6] = 0;
        }
        else if (listc[h] == "Sweet Buns")
        {
            productsc[7] = 0;
        }
        listc[h] = "";
        for (int x = 0; x < 8; x++)
        {
            if (listc[x] == "")
            {
            }
            else if (listc[x] != "")
            {
                Newlist[k1] = listc[x];
                k1 = k1 + 1;
            }
        }
        g = 8 - k1;
        for (int x = 0; x < g; x++)
        {
            Newlist[k1] = "";
            k1 = k1 + 1;
        }
        i2 = i2 - 1;
        listc = Newlist;
        rValue5.SetActive(true);
    }
    public void rembtn7()
    {
        int h = 6;
        k1 = 0;
        if (listc[h] == "ChocoVanila Cake")
        {
            productsc[0] = 0;
        }
        else if (listc[h] == "Healthy Fruit cake")
        {
            productsc[1] = 0;
        }
        else if (listc[h] == "CandyCorn Cake")
        {
            productsc[2] = 0;
        }
        else if (listc[h] == "Oreo-Vanilla Cake")
        {
            productsc[3] = 0;
        }
        else if (listc[h] == "Sprinkled Donuts")
        {
            productsc[4] = 0;
        }
        else if (listc[h] == "ChocoFilled Pastries")
        {
            productsc[5] = 0;
        }
        else if (listc[h] == "Fruit Pastries")
        {
            productsc[6] = 0;
        }
        else if (listc[h] == "Sweet Buns")
        {
            productsc[7] = 0;
        }
        listc[h] = "";
        for (int x = 0; x < 8; x++)
        {
            if (listc[x] == "")
            {
            }
            else if (listc[x] != "")
            {
                Newlist[k1] = listc[x];
                k1 = k1 + 1;
            }
        }
        g = 8 - k1;
        for (int x = 0; x < g; x++)
        {
            Newlist[k1] = "";
            k1 = k1 + 1;
        }
        i2 = i2 - 1;
        listc = Newlist;
        rValue6.SetActive(true);
    }
    public void rembtn8()
    {
        int h = 7;
        k1 = 0;
        if (listc[h] == "ChocoVanila Cake")
        {
            productsc[0] = 0;
        }
        else if (listc[h] == "Healthy Fruit cake")
        {
            productsc[1] = 0;
        }
        else if (listc[h] == "CandyCorn Cake")
        {
            productsc[2] = 0;
        }
        else if (listc[h] == "Oreo-Vanilla Cake")
        {
            productsc[3] = 0;
        }
        else if (listc[h] == "Sprinkled Donuts")
        {
            productsc[4] = 0;
        }
        else if (listc[h] == "ChocoFilled Pastries")
        {
            productsc[5] = 0;
        }
        else if (listc[h] == "Fruit Pastries")
        {
            productsc[6] = 0;
        }
        else if (listc[h] == "Sweet Buns")
        {
            productsc[7] = 0;
        }
        listc[h] = "";
        for (int x = 0; x < 8; x++)
        {
            if (listc[x] == "")
            {
            }
            else if (listc[x] != "")
            {
                Newlist[k1] = listc[x];
                k1 = k1 + 1;
            }
        }
        g = 8 - k1;
        for (int x = 0; x < g; x++)
        {
            Newlist[k1] = "";
            k1 = k1 + 1;
        }
        i2 = i2 - 1;
        listc = Newlist;
        rValue7.SetActive(true);
    }
}
