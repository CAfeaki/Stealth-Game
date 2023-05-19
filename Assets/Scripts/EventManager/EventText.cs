using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventText : MonoBehaviour
{
    public Text textBox;
    public string textToShow;

    public void DisplayText()
    {
        textBox.enabled = true;
    }

    public void ChangeText()
    {
        textBox.text = textToShow;
    }
}
