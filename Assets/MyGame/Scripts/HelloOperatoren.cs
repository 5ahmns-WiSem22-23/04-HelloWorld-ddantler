using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    public bool wert1 = true;
    public bool wert2 = false;

    public float zahl1 = 12;
    public float zahl2 = 3;

    public string wort1;
    public string wort2;


    // Update is called once per frame
    void Start ()
    {
        if (wert1 || wert2)
        {
            Debug.Log("This is a Test. 1 2 3. This is a Test.");
        }

        if (zahl1 == zahl2)
        {
            Debug.Log("This is another Test. 1 2 3. This is another Test.");
        }

        if (zahl1 > zahl2)
        {
            Debug.Log("The first Number given is higher than the second Number given");
        }

        int a, b, c;
        a = 7;
        b = a;
        c = b++;
        b = a + b * c;
        c = a >= 100 ? b : c / 10;

        string s = "String literal";
        char l = s[s.Length - 1];

        var numbers = new List<int>(new[] { 1, 2, 3 });
        b = numbers.FindLast(n => n > 1);
    }
}
