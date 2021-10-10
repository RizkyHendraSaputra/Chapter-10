using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public bool ToSpawn = true;
    public GameObject Planet1;
    public GameObject Planet2;
    public GameObject Planet3;
    public GameObject Planet4;
    public Transform[] Posisi;
    public Transform Lokasi;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Lokasi = Posisi[Random.Range(0, Posisi.Length)];
        if(ToSpawn == true)
        {
            Instantiate(Planet1, Lokasi);
            ToSpawn = false;
            StartCoroutine(ToSpawnTrue());
           
        }
    }
    IEnumerator ToSpawnTrue()
    {
        yield return new WaitForSeconds(3f);
        ToSpawn = true;
    }
}
