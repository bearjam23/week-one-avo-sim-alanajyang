using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barClass : MonoBehaviour
{
    public Slider slider;

    public void reset(float maxVal) 
    {
        slider.maxValue = maxVal;
        slider.value = maxVal;
    }

    public void setValue(float val)
    {
        slider.value = val;
    }
}
