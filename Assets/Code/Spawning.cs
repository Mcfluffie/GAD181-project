using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    private float spawning = 0;
    public float rangeMin;
    public float rangeMax;
    public Transform[] spawnpoint;
    public GameObject[] Prefabs;
    public bool Set;
    public float spawn_Value;
    // Update is called once per frame
    void Update()
    {
        spawning -= Time.deltaTime;
        if (Set == true && spawning <= 0)
        {
            int randomInt = Random.Range(0, Prefabs.Length);
            Instantiate(Prefabs[randomInt], spawnpoint[0].position, transform.rotation);
            spawning = spawn_Value;
        }
            if (Set == false && spawning <= 0 )
        {
            int randomInt = Random.Range(0, Prefabs.Length);
            Instantiate(Prefabs[randomInt], spawnpoint[0].position, transform.rotation);
            spawning = Random.Range(rangeMin, rangeMax);
        }

    }
}
