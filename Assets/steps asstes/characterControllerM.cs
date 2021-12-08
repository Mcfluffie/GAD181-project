using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float PlayerSpeed = 5;
    private Rigidbody2D rb;
    private float canJump = 0f;
    public float jumpforce;
    private bool isJumping;

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

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);

        }
    }




}
