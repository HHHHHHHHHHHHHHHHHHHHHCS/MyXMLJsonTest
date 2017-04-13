using UnityEngine;
using System.Collections;
using AssemblyCSharp1;
using UnityEngine.UI;

public class testinsert : MonoBehaviour
{
    public Text guitext;
    public Text platform;
    string allscores = "";

    void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            platform.text = "Android";
        }
        else
        {
            platform.text = "PC";
        }
    }

    // Use this for initialization
    void Start()
    {

        StartCoroutine(AddressData1.GetXML());
        //AddressData1.insertNode(22);

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 40, 40), "load"))
        {
            foreach (int score in AddressData1.allScore)
            {
                allscores += score.ToString();
                guitext.text += '\t';
            }
            guitext.text = allscores;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}