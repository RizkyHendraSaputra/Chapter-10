using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public bool ToSpawn = true;
    public GameObject Object;
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
            Instantiate(Object, Lokasi);
            ToSpawn = false;
            StartCoroutine(ToSpawnTrue());
        }
    }
    IEnumerator ToSpawnTrue()
    {
        yield return new WaitForSeconds(0.75f);
        ToSpawn = true;
    }
}
