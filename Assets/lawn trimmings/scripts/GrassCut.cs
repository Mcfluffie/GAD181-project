using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassCut : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
    {
        {
            if (other.gameObject.tag == "Player")
            {
                Debug.Log("Collision!");
                Destroy(other.gameObject);
            }
                
        }
    }
}
