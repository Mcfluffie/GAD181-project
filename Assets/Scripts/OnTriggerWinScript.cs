using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerWinScript : MonoBehaviour

{
    void OnTriggerEnter2D (Collider2D other)

    {
        int index = Random.Range(1, 12);
        SceneManager.LoadScene(index);
    }

}
