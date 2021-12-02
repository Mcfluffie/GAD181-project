using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombinationChecker : MonoBehaviour
{
    

    private int number;
    public int TheCombination;
    private int countGuess;

    [SerializeField]
    public InputField input;

    [SerializeField]
    private Text text;


    void Awake()
    {
        number = TheCombination;
        TheCombination = Random.Range(10000000, 100000000);
    }
    public void GetInput(string answer)
    {
        CompareAnswer(int.Parse(answer));
        input.text = "";
    }

    void CompareAnswer(int answer)
    {
        if (answer == number)
        {
            text.text = "Correct Answer, Well Done";

        }
        else if (answer < number)
        {
            text.text = "Incorrect, Try Again";
        }
        else if (answer > number)
        {
            text.text = "Incorrect, Try Again";
        }

    }

}