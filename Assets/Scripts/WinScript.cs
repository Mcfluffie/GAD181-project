using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject myShapes;
   
    void Start()
    {
        pointsToWin = myShapes.transform.childCount;
    }


    void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            int index = Random.Range(1, 12);
            SceneManager.LoadScene(index);

        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
