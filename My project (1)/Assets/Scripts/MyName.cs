using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyName : MonoBehaviour
{
    public static string myName;
    private TMP_Text myText;
    void Start()
    {
        myText = GetComponent<TMP_Text>();
    }

   
    void Update()
    {
        myName = myText.text.ToString();
    }
}
