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


    public void Start()
    {
        rigibod2d = GetComponent<Rigidbody2D>();
        gameRestart();
    }
    public void BolaRest()
    {
        transform.position = Vector2.zero;
        rigibod2d.velocity = Vector2.zero;
    }
    public void bolaBergerak()
    {
        float yRandomInitialForce = Random.Range(-Y, Y);
        float DirectionRandom = Random.Range(0, 3);
        if(DirectionRandom < 1.0f)
        {
            rigibod2d.AddForce(new Vector2(-X, Y));

        }
        else
        {
            rigibod2d.AddForce(new Vector2(X, Y));
        }
    }
    public void gameRestart()
    {
        BolaRest();
        Invoke("bolaBergerak", 2);
    }

}
