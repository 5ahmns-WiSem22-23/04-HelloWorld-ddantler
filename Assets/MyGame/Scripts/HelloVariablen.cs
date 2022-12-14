using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVariablen : MonoBehaviour
{
    //Value Types: Wert wird im Speicher direkt hinterlegt
    int myInt = 0;
    bool myBool = true;
    int[] myArray = new int[3] { 0, 0, 0 };
    string a = "hallo";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));

        //Value Type
        int tmp = myInt;
        myInt = myInt++;
        Debug.Log("myInt: " + myInt + " tmp " + tmp);

        //Reference Type
        int[] tmpArray = myArray;
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        foreach (int a in tmpArray)
        {
            Debug.Log(a);
        }

        Debug.Log("---------- tmpArray");
        foreach (int a in myArray)
        {
            Debug.Log(a);
        }

        string tmpString = a;
        a = "hello";
        Debug.Log("a " + a + " tmpString " + tmpString);
    }
}
