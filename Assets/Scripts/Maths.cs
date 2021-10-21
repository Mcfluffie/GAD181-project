using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maths : MonoBehaviour
{
    string questionText;
    int correctAnswerIndex;
    int multiOperandQuestion()
    {
        int operand1 = Mathf.FloorToInt(Random.value * 30);
        int operand2 = Mathf.FloorToInt(Random.value * 20);
        int operand3 = Random.Range(100, 10000);
        int isMinusOrPlus = Mathf.FloorToInt(Random.value * 2);
        if (isMinusOrPlus == 0)
        {
            questionText = "(" + operand1 + "-" + operand2 + ")*" + operand3 + " = ?";
            return ((operand1 - operand2) * operand3);
        }
        else
        {
            questionText = "(" + operand1 + "+" + operand2 + ")*" + operand3 + " = ?";
            return ((operand1 + operand2) * operand3);
        }

    }
    
}
