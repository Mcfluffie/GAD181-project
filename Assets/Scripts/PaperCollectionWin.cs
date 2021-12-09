using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaperCollectionWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        
        if (transform.childCount <= 0)
        {
            int index = Random.Range(1, 12);
            SceneManager.LoadScene(index);
        }
    }



}
