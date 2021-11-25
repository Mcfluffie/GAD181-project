using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Birdy : MonoBehaviour
{

    public float GameLength;
    public bool fly;
    public bool jump;
    float isGrounded = 0;
    public float Speed = 5;
    public float Rotation = 100;
    public float gravity;
    public float jumpheight;
    float Energy = 18;
    float Pitch;
    int Snacks = 0;
    float Timer = 30;
    float xVelocity;
    float yVelocity;
    float xRotation = 0f;
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
        GameLength -= Time.deltaTime;

        if (GameLength <=0)
        {
            SceneManager.LoadScene(0);
        }
        if (fly == true)
        {
            float mouseX = Input.GetAxis("Mouse X") * Rotation * Time.deltaTime;
            xRotation -= mouseX;
            Pitch = gameObject.transform.eulerAngles.z;
            Bird.Rotate(Vector3.forward * mouseX);
            if (Pitch >= 0)
            {
                Pitch = Pitch / 60;
                xVelocity = Speed * Mathf.Cos(Pitch);
                yVelocity = Speed * Mathf.Sin(Pitch);
                Fly = new Vector2(xVelocity, yVelocity);
                Birds.velocity = Fly;
            }
            if (Pitch < 0)
            {
                Pitch = Pitch / 60;
                Pitch = Pitch - 360;
                xVelocity = Speed * Mathf.Cos(Pitch);
                yVelocity = Speed * Mathf.Sin(Pitch);
                Fly = new Vector2(xVelocity, yVelocity);
                Birds.velocity = Fly;
            }
            if (Timer > 0)
            {
                Timer -= Time.deltaTime;
            }
            else
            {
                //Destroy(gameObject);
                //loss
            }
            if (Energy > 0)
            {
                Energy -= Time.deltaTime;
            }
            else
            {
                //Destroy(gameObject);
                //loss
            }
            if (Snacks == 12)
            {
                //victory
            }
        }
        if (fly == false)
        {
            if (jump == true)
            {
                if (Input.GetButtonDown("Jump") && isGrounded <= 0)
                {
                    //velocity (vertical) is the squar root of jumpheight, gravity and -2
                    isGrounded = 1;
                    yVelocity = 0f;
                    yVelocity = Mathf.Sqrt(jumpheight * -2f * gravity);
                    isGrounded -= Time.deltaTime;
                    Debug.Log("update" + yVelocity);
                }
                yVelocity -= gravity * Time.deltaTime;
                if (jump == false)
                {
                    yVelocity = 0f;
                }
            }
            xVelocity = Input.GetAxisRaw("Horizontal") * Speed;
            Fly = new Vector2(xVelocity, yVelocity);
            Birds.MovePosition(Birds.position + Fly * Time.fixedDeltaTime);

        }

    }
        //on entry with other Collider
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Food")
            {
                Energy += 6;
                Snacks += 1;
                Destroy(other.gameObject);
                //loss
            }
            if (other.gameObject.tag == "Object")
            {
                Destroy(gameObject);
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(0);
                //loss
            }
            if (other.gameObject.tag == "Win")
            {
                //win
            }

        }
}