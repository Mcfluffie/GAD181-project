using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    float isGrounded = 2;
    public float jumpheight;
    public float gravity;
    public float speed;
    float y = 0;
    public Transform Bird;
    Rigidbody2D Birds;
    Vector2 Fly;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if 'Jump' is input (usually spacebar) and "isGrounded" is true
        if (Input.GetButtonDown("Jump") && isGrounded <= 0)
        {
            //velocity (vertical) is the squar root of jumpheight, gravity and -2
            isGrounded = 2;
            y = Mathf.Sqrt(jumpheight * -2f * gravity);
        }
        float x = Input.GetAxis("Horizontal");

        Fly = new Vector2(x, y);
        Birds.velocity = Fly;

        isGrounded -= Time.deltaTime;
        y += gravity * Time.deltaTime;


    }
}
