using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;

public class NetJsonTest : MonoBehaviour
{
    public void Start()
    {
        Product product = new Product();
        product.Name = "Apple";
        product.Expiry = new DateTime(2008, 12, 28);
        product.Sizes = new string[] { "Small" };
        long time = DateTime.Now.Ticks;
        string json;
        for(int i =0;i<1000000;i++)
        {
            json = JsonConvert.SerializeObject(product);
        }
        Debug.Log("Net:"+(DateTime.Now.Ticks- time));
    }

}
