using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    private int startValue2 = 0;
    private int startValue3 = 0;
    private int startValue4 = 10;
    private int startValue5 = 20;

    private int startValue = 0;

    void Start()
    {
        //1) Verwende Start Methode
        Debug.Log("Hallo Methoden!");

        //at 2) Instanzvariable nutzen lol
        Debug.Log("before startValue: " + startValue2);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue2);

        //at 3)
        Debug.Log("before startValue3: " + startValue3);
        IncrementByX(Random.Range(1, 10));
        Debug.Log("after startValue3: " + startValue3);

        //at 4)
        Debug.Log("before startValue4: " + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after startValue4: " + startValue4);

        //at 5)
        Debug.Log("before startValue5: " + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("after startValue5: " + startValue5);
    }

    private int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }
    
    private void IncrementByX(int valtoAdd)
    {
        startValue3 += valtoAdd;
    }

    private void IncrementByOne()
    {
        startValue++;
        //startValue = startValue + 1;
    }

    private void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }
}
