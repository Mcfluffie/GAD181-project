using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideButton : MonoBehaviour
{

    public GameObject setting;
    public GameObject Outlook;
    public GameObject Outlook2;
    public GameObject howToPlay;


    public void ButtonClicked()
    {
        if (setting.activeInHierarchy == true)
            setting.SetActive(false);
        else
            setting.SetActive(true);
    }

    public void ButtonClicked2()
    {
        if (Outlook.activeInHierarchy == true)
            Outlook.SetActive(false);
        else
            Outlook.SetActive(true);
    }

    public void ButtonClicked3()
    {
        if (howToPlay.activeInHierarchy == true)
            howToPlay.SetActive(false);
        else
            howToPlay.SetActive(true);
    }

    public void ButtonClicked4()
    {
        if (Outlook2.activeInHierarchy == true)
            Outlook2.SetActive(false);
        else
            Outlook2.SetActive(true);
    }



}