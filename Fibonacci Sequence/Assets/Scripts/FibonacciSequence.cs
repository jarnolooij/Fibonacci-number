using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class FibonacciSequence : MonoBehaviour
{
    private int a;
    private int b;
    private int c = 0;

    private int currentNumber;

    private int F;
    private bool next;

    public TMP_Text numberCounter;
    public AudioSource audioSource;
    void Start()
    {
        //set some things to default
        next = false;
    }

    //when the button is pressed to these things
    public void nextNumber()
    {
        F++;
        next = true;
        audioSource.Play();
    }

    void Update()
    {
        //the sequence if F is 0
        if (F == 0 && next == true)
        {
            a = 0;
            currentNumber = a;
            Debug.Log(currentNumber);
            numberCounter.SetText(currentNumber.ToString());
            next = false;
        }
        //the sequence if F is 1
        if (F == 1 && next == true)
        {
            b = 1;
            currentNumber = b;
            Debug.Log(currentNumber);
            numberCounter.SetText(currentNumber.ToString());
            next = false;
        }

        //the sequence if F is 2
        if (F == 2 && next == true)
        {
            c = a + b;
            currentNumber = c;
            Debug.Log(currentNumber);
            numberCounter.SetText(currentNumber.ToString());
            next = false;
        }
       
        //the sequence if F is 4
        if (F == 3 && next == true)
        {
            a = b + c;
            currentNumber = a;
            Debug.Log(currentNumber);
            numberCounter.SetText(currentNumber.ToString());
            next = false;
        }
        //the sequence if F is 5
        if (F == 4 && next == true)
        {
            b = c + a;
            currentNumber = b;
            Debug.Log(currentNumber);
            numberCounter.SetText(currentNumber.ToString());
            next = false;
        }
        //if the button is pressed for the 6th time set F back to 0 so the sequence will repeat it self in the right order;
        if(F == 5 && next == true)
        {
            F = 2;
        }
    }
}
