using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Questionare : MonoBehaviour
{
    [SerializeField] TMP_InputField feedback;
    [SerializeField] TMP_InputField pname;
    [SerializeField] TMP_Dropdown dropdown;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSebfuxtCDgYzhjkuXqwbgtEvYkJfZY4_cafOLdUYdwD3DQ28Q/formResponse";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Send()
    {
        StartCoroutine(Post(feedback.text, pname.text, dropdown.value));
    }

    IEnumerator Post(string s1, string n, int d1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.2017985885", s1);
        form.AddField("entry.1064095882", n);
        form.AddField("entry.936826908", d1);
        
        DropDown();

        byte[] ramData = form.data;
        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();
    }

    void DropDown()
    {
        if (dropdown.value == 0)
        {
            Debug.Log(dropdown.value);
            //dropdown.value == "Yes";
        }
        else if (dropdown.value == 1)
        {
            Debug.Log(dropdown.value);
        }
        else if (dropdown.value == 2)
        {
            Debug.Log(dropdown.value);
        }
        else { /*do nothing*/ }
    }
}