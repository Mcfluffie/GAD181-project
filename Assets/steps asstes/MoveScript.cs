using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControllerM : MonoBehaviour
{
    public float PlayerSpeed = 5;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float amtToMove = Input.GetAxis("Horizontal") * PlayerSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * amtToMove);
    }

   
}
