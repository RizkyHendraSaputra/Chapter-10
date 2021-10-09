using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaToouch : MonoBehaviour
{
    // PRIVATE
    private bool gerak = false;
    private float kecepatan = 4;
    private Vector3 posisitujuan;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            PosisiGerakBolaTarget();
        }
        if(gerak)
        {
            GERAKBOLA();
        }
    }
    private void GERAKBOLA()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, posisitujuan);
        transform.position = Vector3.MoveTowards(transform.position, posisitujuan, kecepatan * Time.deltaTime);
        if (transform.position == posisitujuan)
        {
            gerak = false;
        }
    }
   private void PosisiGerakBolaTarget()
    {
        posisitujuan = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posisitujuan.z = transform.position.z;
        gerak = true;
    }
   
}
