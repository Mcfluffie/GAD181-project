using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick : MonoBehaviour
{

    public GameObject thePlayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            thePlayer.GetComponent<Animator>().Play("kick anim");
        }
    }
}
