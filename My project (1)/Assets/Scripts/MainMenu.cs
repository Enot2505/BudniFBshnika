using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void Play(int index)
    {
        SceneManager.LoadScene(index);
    }

    
    public void Exit()
    {
        Application.Quit();
    }
     public void Future()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1 );
    }
    
}
