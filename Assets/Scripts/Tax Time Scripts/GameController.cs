using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int number;
    

    [SerializeField]
    private InputField input;

    [SerializeField]
    private Text text;

    void Awake()
    {
        number = 13500;
        text.text = "Type the Correct Answer in the Box Below ";
       
    }

   public void GetInput(string guess)
    {
        CompareGuesses(int.Parse(guess));
      input.text = ""; 
    }
    void CompareGuesses(int guess)
    {
        if (guess == number)
        {
            text.text = "Correct Answer, Well Done";
            int index = Random.Range(1, 12);
            SceneManager.LoadScene(index);
        } 
        else if (guess < number)
        {
            text.text = "Incorrect Answer, Try Again";
        }
        else if (guess > number)
        {
            text.text = "Incorrect Answer, Try Again";
        }
    }
}
