using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Comperer3Nums : MonoBehaviour
{
    [SerializeField] private InputField inputFieldNum1;
    [SerializeField] private InputField inputFieldNum2;
    [SerializeField] private InputField inputFieldNum3;

    [SerializeField] private Text text;
    int num1;
    int num2;
    int num3;
    string res;
    string res2;

    public void ThreeNumComperer()
    {
        num1 = Convert.ToInt32(inputFieldNum1.text);
        num2 = Convert.ToInt32(inputFieldNum2.text);
        num3 = Convert.ToInt32(inputFieldNum3.text);
        if (num1 > num2 && num3 > num2)
        {
            res = Convert.ToString(num1);
            res2 = Convert.ToString(num3);
            text.text = res + " è " + res2;
        }
        else if (num1 > num3 && num2 > num3)
        {
            res = Convert.ToString(num1);
            res2 = Convert.ToString(num2);
            text.text = res + " è " + res2;
        }
        else if (num2 > num1 && num3 > num1)
        {
            res = Convert.ToString(num2);
            res2 = Convert.ToString(num3);
            text.text = res + " è " + res2;
        }
        else
        {
            text.text = "The numbers are equal";
        }
    }
}
