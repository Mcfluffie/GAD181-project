using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombinationChecker : MonoBehaviour
{
    

    private int number;

    private int countGuess;

    [SerializeField]
    public InputField input;

    [SerializeField]
    private Text text;


    void Awake()
    {
        
        
    }
    public void GetInput(string answer)
    {
        CompareAnswer(int.Parse(answer));
        input.text = "";
    }

    void CompareAnswer(int TheCombination)
    {
        if (TheCombination == number)
        {
            text.text = "Correct Answer, Well Done";

        }
        else if (TheCombination < number)
        {
            text.text = "Incorrect, Try Again";
        }
        else if (TheCombination > number)
        {
            text.text = "Incorrect, Try Again";
        }

    }

}