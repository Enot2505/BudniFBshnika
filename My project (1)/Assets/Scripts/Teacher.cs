using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teacher : MonoBehaviour
{
    public float speed;
    public Vector3[] positions;
    private int currentTarget;
    private SpriteRenderer sprite;
    private Animator anim;
     private void Awake()
    {
        
        anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        
    }
    public void FixedUpdate()
    {   //Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, positions[currentTarget], speed);
        //sprite.flipX = dir.x < 0.0f;
        if( transform.position == positions[currentTarget])
        {
            if (currentTarget<positions.Length-1)
            {
                currentTarget++;
                sprite.flipX = false;
            }
            else 
            {
                currentTarget=0;
                sprite.flipX = true;
            }
        }
    }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  }
  private void OnTriggerEnter2D (Collider2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
       
        Destroy(gameObject);
    }
  }
}
