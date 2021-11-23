using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField inputFieldNum1;
    [SerializeField] private InputField inputFieldNum2;
    int result;
    string res;

    public void Plus()
    {
        result = Convert.ToInt32(inputFieldNum1.text) + System.Convert.ToInt32(inputFieldNum2.text);
        res = Convert.ToString(result);
        text.text = res;
    }

    public void Minus()
    {
        result = Convert.ToInt32(inputFieldNum1.text) - System.Convert.ToInt32(inputFieldNum2.text);
        res = Convert.ToString(result);
        text.text = res;
    }

    public void Multiply()
    {
        result = Convert.ToInt32(inputFieldNum1.text) * System.Convert.ToInt32(inputFieldNum2.text);
        res = Convert.ToString(result);
        text.text = res;
    }

    public void Division()
    {
        result = Convert.ToInt32(inputFieldNum1.text) / System.Convert.ToInt32(inputFieldNum2.text);
        res = Convert.ToString(result);
        text.text = res;
    }

}
