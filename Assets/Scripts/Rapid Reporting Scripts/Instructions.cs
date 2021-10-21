using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public Text instructionsText;
    void Start()
    {
        instructionsText.text = "Type out the words as quickly as possible";
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
    }
}