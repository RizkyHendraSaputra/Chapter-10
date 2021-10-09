using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaGerak : MonoBehaviour
{

    // PUBLIC
    public float X;
    public float Y;

    // PRIVATE
    private Rigidbody2D rigibod2d;
    private Vector2 trajectory;

     void Start()
    {
        trajectory = transform.position;
        rigibod2d = GetComponent<Rigidbody2D>();
        gameRestart();
    }
     void BolaRest()
    {
        transform.position = Vector2.zero;
        rigibod2d.velocity = Vector2.zero;
    }
     void bolaBergerak()
    {
        float yRandomInitialForce = Random.Range(-Y, Y);
        float DirectionRandom = Random.Range(0, 2);
        if(DirectionRandom < 1.0f)
        {
            rigibod2d.AddForce(new Vector2(-X, yRandomInitialForce));

        }
        else
        {
            rigibod2d.AddForce(new Vector2(X, yRandomInitialForce));
        }
    }
     void gameRestart()
    {
        BolaRest();
        Invoke("bolaBergerak", 2);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        trajectory = transform.position;
    }
    public Vector2 trajectory1
    {
        get { return trajectory; }
    }
}
