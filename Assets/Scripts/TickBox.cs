using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickBox : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public bool isTicked = false;


    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
        this.GetComponent<SpriteRenderer>().color = Color.gray;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider.tag == this.GetComponent<BoxCollider2D>().tag)
            {
                ChangeSprite();
                isTicked = true;
            }

            if (hit.collider.tag == "Delete")
            {
                Delete();
            }
        }
    }

    void Delete()
    {
            if(isTicked)
            {
                Destroy(gameObject);
            }
    }
}