using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class Bin : MonoBehaviour
{
    public Object keep1, keep2, keep3, keep4, keep5, keep6, keep7, keep8, keep9, keep10, delete1, delete2, delete3, delete4, delete5, delete6, delete7;
    public Toggle keep1T, keep2T, keep3T, keep4T, keep5T, keep6T, keep7T, keep8T, keep9T, keep10T, delete1T, delete2T, delete3T, delete4T, delete5T, delete6T, delete7T;

    public void bin()
    {
        if (keep1T .isOn)
        {
            Destroy(keep1);
            SceneManager.LoadScene(0);
        }
        if (keep2T.isOn)
        {
            Destroy(keep2);
            SceneManager.LoadScene(0);
        }
        if (keep3T.isOn)
        {
            Destroy(keep3);
            SceneManager.LoadScene(0);
        }
        if (keep4T.isOn)
        {
            Destroy(keep4);
            SceneManager.LoadScene(0);
        }
        if (keep5T.isOn)
        {
            Destroy(keep5);
            SceneManager.LoadScene(0);
        }
        if (keep6T.isOn)
        {
            Destroy(keep6);
            SceneManager.LoadScene(0);
        }
        if (keep7T.isOn)
        {
            Destroy(keep7);
            SceneManager.LoadScene(0);
        }
        if (keep8T.isOn)
        {
            Destroy(keep8);
            SceneManager.LoadScene(0);
        }
        if (keep9T.isOn)
        {
            Destroy(keep9);
            SceneManager.LoadScene(0);
        }
        if (keep10T.isOn)
        {
            Destroy(keep10);
            SceneManager.LoadScene(0);
        }
        if (delete1T.isOn)
        {
            Destroy(delete1);
        }
        if (delete2T.isOn)
        {
            Destroy(delete2);
        }
        if (delete3T.isOn)
        {
            Destroy(delete3);
        }
        if (delete4T.isOn)
        {
            Destroy(delete4);
        }
        if (delete5T.isOn)
        {
            Destroy(delete5);
        }
        if (delete6T.isOn)
        {
            Destroy(delete6);
        }
        if (delete7T.isOn)
        {
            Destroy(delete7);
        }
    }
}
