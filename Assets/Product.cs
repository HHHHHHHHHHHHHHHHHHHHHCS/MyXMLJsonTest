using UnityEngine;
using System.Collections;
using System;

public class Product
{
    private string name;

    private DateTime expiryDate;

    private decimal price;

    private string[] sizes;

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

    public DateTime ExpiryDate
    {
        get
        {
            return expiryDate;
        }

        set
        {
            expiryDate = value;
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

    public override string ToString()
    {
        return string.Format("Name:{0},ExpiryDate:{1},Price:{2},SizesCount:{3}"
            , Name, ExpiryDate, Price, Sizes==null?0: Sizes.Length);
    }
}
