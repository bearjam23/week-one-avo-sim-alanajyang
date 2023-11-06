using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateBar : MonoBehaviour
{
    public float maxVal;
    public float currVal;
    public barClass bar;
    public float decrease_per_sec;
    public float increase_per_click;

    // Start is called before the first frame update
    void Start()
    {
        currVal = maxVal;
        bar.reset(maxVal);
    }

    // Update is called once per frame
    void Update()
    {
        if (currVal >= decrease_per_sec)
        {
            currVal = currVal - decrease_per_sec * Time.deltaTime;
            bar.setValue(currVal);
        }
    }

    public void clickFunc()
    {
        if (currVal < maxVal)
        {
            currVal += increase_per_click;
            bar.setValue(currVal);
        }
    }
}
