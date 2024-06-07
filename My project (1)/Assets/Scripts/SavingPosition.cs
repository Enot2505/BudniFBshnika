using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingPosition : MonoBehaviour
{
    public Transform PlayerPosition;
    private float X,Y;
    
    void Start()
    {
  
    }

    
    void Update()
    {
       X=PlayerPosition.transform.position.x;
       Y=PlayerPosition.transform.position.y; 
       Save();
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("Save [X]",X);
        PlayerPrefs.SetFloat("Save [Y]",Y);
    }
    public void Load()
    {
        if (PlayerPrefs.HasKey("Save [X]"))
        {
            X=PlayerPrefs.GetFloat("Save [X]");
        }
         if (PlayerPrefs.HasKey("Save [Y]"))
        {
            Y=PlayerPrefs.GetFloat("Save [Y]");
        }
        PlayerPosition.transform.position = new Vector3(X,Y);
    }
}
