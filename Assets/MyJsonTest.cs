using UnityEngine;
using System.Collections;
using Newtonsoft.Json;
using System;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class MyJsonTest : MonoBehaviour
{


    void Awake()
    {

    }

    void Start()
    {
        Test1();
        //Test2();
        //Test3();
        //Test4();
    }

    void Test1()
    {
        Product product = new Product();
        product.Name = "Apple";
        product.Expiry = new DateTime(2008, 12, 28);
        product.Price = 3.99M;
        product.Sizes = new string[] { "Small", "Medium", "Large" };
        product.CanSell = true;

        string output = JsonConvert.SerializeObject(product);
        Debug.Log(output);
        Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
        Debug.Log(deserializedProduct.Name);
    }

    void Test2()
    {
        Product product = new Product();
        product.Expiry = new DateTime(2008, 12, 28);

        JsonSerializer serializer = new JsonSerializer();
        serializer.Converters.Add(new JavaScriptDateTimeConverter());
        serializer.NullValueHandling = NullValueHandling.Ignore;

        using (StreamWriter sw = new StreamWriter(@"MyJson.txt"))
        using (JsonWriter writer = new JsonTextWriter(sw))
        {
            serializer.Serialize(writer, product);
            // {"ExpiryDate":new Date(1230375600000),"Price":0}
            Debug.Log(product.ToString());
            
        }
    }

    void Test3()
    {
        string strJson = @"{""Name1"": ""小明"",""Name2"": ""小花"",""Name3"": ""小红""}";

        Dictionary<string, string> _dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(strJson);

        foreach (KeyValuePair<string, string> kp in _dictionary)
        {
            Debug.Log(kp.Key + ":" + kp.Value);
        }
    }

    void Test4()
    {
        Debug.Log( MyJsonManager.GetData("name"));
        MyJsonManager.UpdateData("name", "yoooooo");
        Debug.Log(MyJsonManager.GetData("name"));
    }

    void Test5()
    {

    }

}
