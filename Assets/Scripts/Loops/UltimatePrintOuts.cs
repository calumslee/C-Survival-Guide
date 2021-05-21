using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimatePrintOuts : MonoBehaviour
{
    //Create a program that prints out 0-10, then prints only even numbers to 20, only odd to 30

    private void Start()
    {
        for (int i = 0; i <= 30; i++)
        {
            if (i <= 10)
            {
                Debug.Log(i);
            }
            else if (i > 10 & i <= 20)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
            else if (i > 20 & i <= 30)
            {
                if (i % 2 == 1)
                {
                    Debug.Log(i);
                }
            }
        }
        
    }
}
