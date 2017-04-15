using UnityEngine;
using System.Collections;
using System;

public class Product
{
    private string name;

    private DateTime expiry;

    private decimal price;

    private string[] sizes;
    private string[] sizes1= { "Small" };
    private string[] sizes2= { "Small" };
    private string[] sizes3= { "Small" };
    private string[] sizes4= { "Small" };

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public DateTime Expiry
    {
        get
        {
            return expiry;
        }

        set
        {
            expiry = value;
        }
    }

    public decimal Price
    {
        get
        {
            return price;
        }

        set
        {
            price = value;
        }
    }

    public string[] Sizes
    {
        get
        {
            return sizes;
        }

        set
        {
            sizes = value;
        }
    }

    public string[] Sizes1
    {
        get
        {
            return sizes1;
        }

        set
        {
            sizes1 = value;
        }
    }

    public string[] Sizes2
    {
        get
        {
            return sizes2;
        }

        set
        {
            sizes2 = value;
        }
    }

    public string[] Sizes3
    {
        get
        {
            return sizes3;
        }

        set
        {
            sizes3 = value;
        }
    }

    public string[] Sizes4
    {
        get
        {
            return sizes4;
        }

        set
        {
            sizes4 = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Name:{0},ExpiryDate:{1},Price:{2},SizesCount:{3}"
            , Name, Expiry, Price, Sizes==null?0: Sizes.Length);
    }
}
