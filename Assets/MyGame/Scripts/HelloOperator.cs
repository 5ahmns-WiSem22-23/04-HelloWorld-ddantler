using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloOperator : MonoBehaviour
{
    public InputField inputField;
    public Text resultText;

    void Start()
    {
        inputField.onEndEdit.AddListener(CheckIfNumberIsOdd);
    }

    void CheckIfNumberIsOdd(string input)
    {
        int number;
        if (int.TryParse(input, out number))
        {
            if (number % 2 == 0)
            {
                resultText.text = "The number is even.";
            }
            else
            {
                resultText.text = "The number is odd.";
            }
        }
        else
        {
            resultText.text = "Please enter a valid number:";
        }
    }
}