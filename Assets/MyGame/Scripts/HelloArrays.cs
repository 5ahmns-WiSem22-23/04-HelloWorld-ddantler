using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArrays : MonoBehaviour
{
    readonly int capitalA = 65;

    private char[,] myArrayOne = { { 'A', 'B', 'C', 'D' }, { 'E', 'F', 'G', 'H' }, { 'I', 'J', 'K', 'L' } };
    private char[,] myArrayTwo = new char[3, 4];

    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int ascii = capitalA + 4 * i + j;
                myArrayTwo[i, j] = (char)ascii;
            }
        }

        Debug.Log($"Row: {myArrayTwo.GetLength(0)}");
        Debug.Log($"Column: {myArrayTwo.GetLength(1)}");
    }
}