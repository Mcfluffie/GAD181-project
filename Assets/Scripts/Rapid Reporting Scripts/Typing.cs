using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Typing : MonoBehaviour

{
    public WordBank wordBank = null;
    public Text wordOutput = null;

    public int numWordsToComplete = 10;

    private string remainingWord = string.Empty;
    private string currentWord = string.Empty;

    
    private void Start()
    {
        SetCurrentWord();
    }

   private void SetCurrentWord()
    {
        currentWord = wordBank.GetWord();
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }
     private void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if(Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if (keysPressed.Length == 1)
                EnterLetter(keysPressed);
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if(IsCorrectLetter(typedLetter))
        {
            RemoveLetter();

            if (IsWordComplete())
            {
                numWordsToComplete--;
                if(numWordsToComplete <= 0)
                {
                    Win();
                }
                else
                {
                    SetCurrentWord();
                }                
            }                
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {
        return remainingWord.Length == 0;
    }

    public void Win()
    {
        int index = Random.Range(1, 12);
        SceneManager.LoadScene(index);
    }
}
