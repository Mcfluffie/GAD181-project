using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{

    public Sprite playerUp, playerLeft, playerRight, playerDown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
    }


    private void UpdatePosition()
    {

        Vector2 pos = transform.localPosition;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<SpriteRenderer>().sprite = playerUp;
            pos += Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GetComponent<SpriteRenderer>().sprite = playerDown;
            pos += Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().sprite = playerLeft;
            pos += Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().sprite = playerRight;
            pos += Vector2.right;
        }
                

        transform.localPosition = pos;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            Destroy(gameObject);
        }
    }





}
