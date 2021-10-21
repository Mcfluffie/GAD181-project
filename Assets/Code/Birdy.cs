using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public float Speed = 5;
    public float Rotation = 500;
    public float Energy = 100;
    float Pitch;
    public float xVelocity;
    float yVelocity;
    float yRotation = 0f;
    public Transform Bird;
    Rigidbody2D Birds;
    Vector2 Fly;
    //public int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Birds = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * Rotation * Time.deltaTime;
        yRotation -= mouseY;
        Pitch = gameObject.transform.eulerAngles.z;
        Bird.Rotate(Vector3.forward * mouseY);
        if(Pitch >= 0)
        {
            xVelocity = Speed * Mathf.Cos(Pitch);
            yVelocity = Speed * Mathf.Sin(Pitch);
            Fly = new Vector2(xVelocity, yVelocity);
            Birds.velocity = Fly;
        }
        if (Pitch < 0)
        {
            Pitch = Pitch - 360;
            xVelocity =Speed * Mathf.Cos(Pitch);
            yVelocity =Speed * Mathf.Sin(Pitch);
            Fly = new Vector2(xVelocity, yVelocity);
            Birds.velocity = Fly;
        }

    }
    //on entry with other Collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Food")
        {
            Energy += 20;
        }
        else if (other.gameObject.tag == "Object")
        {
            //Event
            Destroy(gameObject);
        }
        //timer += 1;  
        //if (timer == 6)
        //{
        //    timer = 6;
        //    Energy -= 1;
        //}
    }
}
 