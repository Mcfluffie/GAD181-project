using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CombinationChecker : MonoBehaviour
{
    

    private int number;
    private int countGuess;

    [SerializeField]
    public InputField input;

    [SerializeField]
    public Text resultText;
    public Text generatorCode;


    void Awake()
    {
        number = Random.Range(10000000, 100000000);
    }
    public void GetInput(string answer)
    {
        CompareAnswer(answer);
        input.text = "";
    }

    void CompareAnswer(string answer)
    {
        if (answer == number.ToString())
        {
            resultText.text = "Correct Answer, Well Done";
            int index = Random.Range(1, 12);
            SceneManager.LoadScene(index);
        }
        else
        {
            resultText.text = "Incorrect, Try Again";
            Debug.Log(answer + " solution = " + number);
        }

    }

    public void DisplayNumber()
    {
        generatorCode.text = "" + number;
    }

}