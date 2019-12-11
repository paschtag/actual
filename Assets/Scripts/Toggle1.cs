using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle1 : MonoBehaviour
{
     public Button MyButton;
    public Slider MySlider;
    public Toggle MyToggle;

    public void Toggle_Changed(bool newValue)
    {
        MyButton.enabled = newValue;
        MySlider.interactable = newValue;
    }
}
