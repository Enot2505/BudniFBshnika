using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D collisoin)
    {
        if (collisoin.tag == "Player")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1 );
            
        }
    }
}
