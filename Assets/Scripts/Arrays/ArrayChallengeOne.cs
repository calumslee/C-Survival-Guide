using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ArrayChallengeOne : MonoBehaviour
{
    //Create an array of
    //5 names and print the last name
    //5 ages and print the last age
    //5 cars and print the last car

    //Bonus -- Print when space key is pressed

    [SerializeField]
    private string[] names = new string[5];
    [SerializeField]
    private int[] ages = new int[5];
    [SerializeField]
    private string[] cars = new string[5];

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int i = Random.Range(0, names.Length);
            Debug.Log(names[i]);
            Debug.Log(ages[i]);
            Debug.Log(cars[i]);
        }
    }

}
