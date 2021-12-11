using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumberGenerator : MonoBehaviour
{
    [SerializeField]
    public GameObject TextBox;
    public int TheCombination;
    
    public void RandomGenerate()
    {
        TheCombination = Random.Range(10000000, 100000000);
        TextBox.GetComponent<Text>().text = "" + TheCombination;
    }
    
    
    }

    

