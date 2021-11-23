using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SquareEquals : MonoBehaviour
{

    [SerializeField] private InputField inputFieldNum1;
    [SerializeField] private InputField inputFieldNum2;
    [SerializeField] private InputField inputFieldNum3;
    [SerializeField] private GameObject error;

    [SerializeField] private Text text;
    int a;
    int b;
    int c;
    int D;
    int x1;
    int x2;
    string res;
    string res2;
   
    public void squareEquals()
    {
        a = Convert.ToInt32(inputFieldNum1.text);
        b = Convert.ToInt32(inputFieldNum2.text);
        c = Convert.ToInt32(inputFieldNum3.text);

        if (a == 0)
        {
            error.SetActive(true);
            return;
        }

        D = b * b - (4 * a * c);

        if (D < 0)
        {
            text.text = "Equation has no roots";
            error.SetActive(false);
        }
        else if (D == 0)
        {
            x1 = (-b) / a * 2;
            res = Convert.ToString(x1);
            text.text = "x1 = " + res;
            error.SetActive(false);
        }
        else
        {
            double sqrD = Convert.ToDouble(D);
            D = Convert.ToInt32(Math.Sqrt(sqrD));
            x1 = ((-b) + D) / (a * 2);
            x2 = ((-b) - D) / (a * 2);
            res = Convert.ToString(x1);
            res2 = Convert.ToString(x2);
            text.text = "x1 = " + res + ", " + "x2 = " + res2;
            error.SetActive(false);
        }
    }
}
