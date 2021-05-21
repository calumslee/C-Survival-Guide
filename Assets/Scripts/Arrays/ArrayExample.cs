using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    [SerializeField]
    private string[] names;     //Declared through inspector

    [SerializeField]
    private string[] items = new string[5]; //Size declared in code

    [SerializeField]
    private int[] ages = new int[] { 5, 7, 2, 65, 23 }; //Array completely declared in code

    private void Start()
    {
        Debug.Log(names[2]);
        Debug.Log(ages[1]);
        Debug.Log(items[4]);
    }
}
