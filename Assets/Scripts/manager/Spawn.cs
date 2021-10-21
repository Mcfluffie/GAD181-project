using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float spawning = 0;
    public Transform[] spawnpoint;
    public GameObject[] Prefabs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawning -= Time.deltaTime;
        if (spawning <= 0)
        {
            int randomInt = Random.Range(0, Prefabs.Length);
            Instantiate(Prefabs[randomInt], spawnpoint[0].position, transform.rotation);
            spawning = Random.Range(0.5f, 2f);
        }

    }
}
