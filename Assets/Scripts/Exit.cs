using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public void doExitGame()
    {
        Debug.Log("game has ended");
        Application.Quit();
    }
}

