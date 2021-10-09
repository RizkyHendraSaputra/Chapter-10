using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaGerakManual : MonoBehaviour
{
    // PUBLIC
    public Vector2 gerak;
    public float gerakkecepatanbola;
    // PRIVATE
    private Rigidbody2D rigidbod2d;
    // Start is called before the first frame update

    void Start()
    {
        rigidbod2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        gerak.x = Input.GetAxisRaw("Horizontal");
        gerak.y = Input.GetAxisRaw("Vertical");
        
    }
     void FixedUpdate()
    {
        rigidbod2d.MovePosition(rigidbod2d.position + gerak * gerakkecepatanbola * Time.fixedDeltaTime);
    }
}
