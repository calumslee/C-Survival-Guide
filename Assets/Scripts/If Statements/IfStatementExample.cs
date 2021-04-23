using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementExample : MonoBehaviour
{
    public int myAge = 22;
    private int _legalAgeToDrive = 16;

    // Start is called before the first frame update
    void Start()
    {
        //if condition
        //then run code
        //else
        //run other code

        //if myAge is greater than or equal to 16
        //then print out you can drive
        //else
        //print out you can not drive

        if (myAge >= _legalAgeToDrive)
        {
            Debug.Log("You can drive.");
        }
        else
        {
            Debug.Log("You can not drive.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
