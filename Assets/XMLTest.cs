using UnityEngine;
using System.IO;
using System.Xml;
using System.Collections;

public class XMLTest : MonoBehaviour
{

    private string _xmlPath;
    private string _userId = "";
    private string _userName = "";



    // Use this for initialization
    void Start()
    {
        //xml路径
        _xmlPath = Application.dataPath + "/test.xml";
        CreatXML();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreatXML()
    {
        //检测xml是否存在
        if (!File.Exists(_xmlPath))
        {
            //新建xml实例
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDec = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //创建根节点，最上层节点
            XmlElement data = xmlDoc.CreateElement("data");
            xmlDoc.AppendChild(data);
            //二级节点
            XmlElement user = xmlDoc.CreateElement("user");
            data.AppendChild(user);
            //二级节点的两个属性
            XmlElement userId = xmlDoc.CreateElement("userId");
            user.AppendChild(userId);
            XmlElement userName = xmlDoc.CreateElement("userName");
            user.AppendChild(userName);

            //将xml文件保存到本地
            xmlDoc.Save(_xmlPath);
            Debug.Log("xml creat success!");
        }
    }

    void OnGUI()
    {
        GUI.Button(new Rect(0, 0, 100, 50), "UserId");

        _userId = GUI.TextField(new Rect(100, 0, 100, 50), _userId);


        GUI.Button(new Rect(0, 50, 100, 50), "UserName");


        _userName = GUI.TextField(new Rect(100, 50, 100, 50), _userName);
        if (GUI.Button(new Rect(200, 25, 100, 50), "更改"))
        {
            UpdateXml(_userId, _userName);
        }


        //GUI.Button(new Rect(0, 100, 150, 50), "UserId" + _userId);
        //GUI.Button(new Rect(0, 150, 150, 50), "UserName" + _userName);


    }

    void UpdateXml(string userId, string userName)
    {
        if (File.Exists(_xmlPath))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_xmlPath);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("data/user").ChildNodes;
            foreach (XmlElement xe in nodeList)
            {
                Debug.Log(nodeList.Count);
                if (xe.Name == "userId")
                {
                    xe.InnerText = userId;
                    Debug.Log("edit");

                }
                if (xe.Name == "userName")
                {
                    xe.InnerText = userName;
                    break;
                }
            }
            xmlDoc.Save(_xmlPath);
        }
    }
}