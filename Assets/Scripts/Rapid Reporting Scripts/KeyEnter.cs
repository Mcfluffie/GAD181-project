using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class KeyEnter : MonoBehaviour
{
    public KeyCode key;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            GetComponent<Button>().onClick.Invoke();
        }
    }
}