using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D RB;
    void Start()
    {
        RB.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D( Collider2D collision)
    {
        Debug.Log(collision.name);
        Destroy(gameObject);
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
        }
       



    }



     void OnTriggerEnter2D(Collider hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
        
    }



}
