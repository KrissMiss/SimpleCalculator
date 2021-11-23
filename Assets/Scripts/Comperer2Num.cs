using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Comperer2Num : MonoBehaviour
{
    [SerializeField] private InputField inputFieldNum1;
    [SerializeField] private InputField inputFieldNum2;

    [SerializeField] private Text text;
    int num1;
    int num2;
    string res;

    public void TwoNumComperer()
    {
        num1 = Convert.ToInt32(inputFieldNum1.text);
        num2 = Convert.ToInt32(inputFieldNum2.text);
        if (num1 > num2)
        {
            res = Convert.ToString(num1);
            text.text = res;
        }
        else if (num1 < num2)
        {
            res = Convert.ToString(num2);
            text.text = res;
        }
        else
        {
            text.text = "The numbers are equal";
        }
    }
}
