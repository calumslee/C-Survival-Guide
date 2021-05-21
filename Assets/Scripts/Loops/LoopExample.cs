using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExample : MonoBehaviour
{
    private int _apples;

    private void Start()
    {
        /*do                              //Do While Loops
        {
            Debug.Log("Apples = " + _apples);
            _apples++;
        }   while (_apples <= 20);*/

        while (_apples <= 20)             //While Loops = Much Cleaner than Do While
        {
            Debug.Log("Apples = " + _apples);
            _apples++;
        }

        StartCoroutine(LoopIncrement());
    }

    private IEnumerator LoopIncrement() //For Loops
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 1) //odd numbers using modulus operator
            {
                Debug.Log(i);
            }
            else if (i == 50) //break out early
            {
                break;
            }
            yield return new WaitForSeconds(1.0f);
        }

        Debug.Log("Loop Finished");
    }
}
