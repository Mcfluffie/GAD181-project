using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
    {
        {
            if (other.gameObject.tag == "paper")
            {
                Debug.Log("Collision!");
                Destroy(other.gameObject);
            }
                
        }
    }
}
