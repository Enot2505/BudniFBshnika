using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
 public List<GameObject> character;
 public Vector3 position;
 private int characterId;
 public GameObject Player1 ;
 public GameObject Player2 ;
    
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    private Vector3 pos;
private void Start()
{
    characterId = PlayerPrefs.GetInt("Character", characterId);
    if (characterId==0)
    {
        Player2.SetActive(false);
    }
    if (characterId==1){
        Player1.SetActive(false);
    }
}
    private void Awake()
    { 
        if (!player1 || !player2)
        {
            if (characterId==0)
            {
                player1 = FindObjectOfType<Hero>().transform;
            }
            if (characterId==1)
            {
                player2 = FindObjectOfType<Hero>().transform;
            }
        }
    }
   
    void Update()
    {
        if (characterId==0)
            {
                pos = player1.position;
            }
            if (characterId==1)
            {
                pos = player2.position;
            }
        pos.z =-10f;
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime); 
    }
}

