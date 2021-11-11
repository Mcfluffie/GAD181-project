using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D ai;
    private float Speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        ai = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        ai.velocity = new Vector2(Speed, 0);
    }
    //on entry with other Collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
        Destroy(gameObject);
        }
        if (other.gameObject.tag == "Nest")
        {
        Destroy(gameObject);
        }

    }
}