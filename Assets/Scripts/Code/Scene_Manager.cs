using UnityEngine;
//using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    //public Button yourButton;
    public int level = 0;
    public int minLevel;
    public int maxLevel;
    public bool set;
    public static bool press = false;

    public void TaskOnClick()
    {
        if (set == true)
        {
            Debug.Log("Set");
            SceneManager.LoadScene(level);
        }
        if (set == false)
        {
            //This works because it converts a float to an int
            //level = Mathf.RoundToInt(Random.Range(1f, 2f));
            //For random range with INT the max is exclusive rather than inclusive so add +1
            level = Random.Range(minLevel, maxLevel + 1);
            Debug.Log("Level loaded " + level);
            SceneManager.LoadScene(level);
        }
    }
}
