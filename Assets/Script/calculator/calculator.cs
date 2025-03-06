using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculator : MonoBehaviour
{
    public Text result;
    public Text process;
    private int currentResult = 0;
    private string currentOperation = "";
    private bool isNewInput = true;

    public void Start()
    {
        currentResult = 0;
        currentOperation = "";
        result.text = "0";
        process.text = "";
    }
    public void addfunction()
    {
        HandlePreviousOperation();
        currentOperation = "+";
        process.text += " + ";
        isNewInput = true;
    }

    public void subfunction()
    {
        HandlePreviousOperation();
        currentOperation = "-";
        process.text += " - ";
        isNewInput = true;
    }

    public void multifunction()
    {
        HandlePreviousOperation();
        currentOperation = "*";
        process.text += " * ";
        isNewInput = true;
    }

    public void divfunction()
    {
        HandlePreviousOperation();
        currentOperation = "/";
        process.text += " / ";
        isNewInput = true;
    }

    public void btn0() { Number("0"); }
    public void btn1() { Number("1"); }
    public void btn2() { Number("2"); }
    public void btn3() { Number("3"); }
    public void btn4() { Number("4"); }
    public void btn5() { Number("5"); }
    public void btn6() { Number("6"); }
    public void btn7() { Number("7"); }
    public void btn8() { Number("8"); }
    public void btn9() { Number("9"); }

    private void Number(string number)
    {
        if (isNewInput)
        {
            result.text = number;
            process.text += number;
            isNewInput = false;
        }
        else
        {
            if (result.text == "0")
            {
                result.text = number;
            }
            else
            {
                result.text += number;
            }
            process.text += number;
        }
    }

    private void HandlePreviousOperation()
    {
        int currentInput = int.Parse(result.text);

        if (currentOperation == "")
        {
            currentResult = currentInput;
        }
        else
        {
            if (currentOperation == "+")
            {
                currentResult += currentInput;
            }
            else if (currentOperation == "-")
            {
                currentResult -= currentInput;
            }
            else if (currentOperation == "*")
            {
                currentResult *= currentInput;
            }
            else if (currentOperation == "/")
            {
                currentResult /= currentInput;
            }
        }

        result.text = currentResult.ToString();
    }

    public void resultFunc()
    {
        HandlePreviousOperation();
        process.text += " = " + currentResult.ToString();
        result.text = currentResult.ToString();
        isNewInput = true;
        currentOperation = "";
    }

    public void resetFunc()
    {
        currentResult = 0;
        currentOperation = "";
        result.text = "0";
        process.text = "";
        isNewInput = true;
    }

    void Update()
    {

    }
}
