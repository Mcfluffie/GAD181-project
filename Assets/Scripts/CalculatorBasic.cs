using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CalculatorBasic : MonoBehaviour
{
    [SerializeField]
    Text numberImputField;

    string imputString;
    int[] number = new int[2];
    string operatorSymbol;
    int i = 0;
    int result;
    bool displayedResults = false;

    public void ButtonIsPressed()
    {
        if (displayedResults == true)
        {
            numberImputField.text = "";
            imputString = "";
            displayedResults = false;
        }
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        imputString += buttonValue;


        int arg;
        if (int.TryParse(buttonValue, out arg))
        {
            if (i > 1) i = 0;
            number[i] = arg;
            i = i + 1;
        }
        else
        {
            switch (buttonValue)
            {
                case "+":
                    operatorSymbol = buttonValue;
                    break;
                case "-":
                    operatorSymbol = buttonValue;
                    break;
                case "=":
                    switch (operatorSymbol)
                    {
                        case "+":
                            result = number[0] + number[1];
                            break;
                        case "-":
                            result = number[0] - number[1];
                            break;
                    }
                    displayedResults = true; 
                    imputString = result.ToString();
                    number = new int[2];
                    break;
            }
                    
        }

            
        
        numberImputField.text = imputString;

    }
     

}

    

