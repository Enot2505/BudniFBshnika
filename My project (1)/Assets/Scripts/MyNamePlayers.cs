using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyNamePlayers : MonoBehaviour
{

    private TMP_Text myText;
    void Start()
    {
        myText = GetComponent<TMP_Text>();
        myText.text = "Добро пожаловать "+MyName.myName + "!!!";
    }

   
  
}
