using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Charachter : MonoBehaviour
{
    public string objectName;
    public int id;
    public void saveInt()
    {
        PlayerPrefs.SetInt(objectName, id);
        SceneManager.LoadScene(2);
    }

}
