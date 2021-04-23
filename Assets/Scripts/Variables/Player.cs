using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Create a variable to store your name
    //Create a variable to store your age
    //Create a variable to store your speed
    //Create a health variable
    //Create a score variable
    //Variable to check if all keys were collected
    //Variable for ammo count

    public string myName = "Calum";
    public int myAge = 22;
    public float mySpeed = 3.2f;
    public int myHealth = 100;
    public int myScore = 50;
    public bool hasAllKeys = false;
    public int ammoCount = 240;

    // Start is called before the first frame update
    void Start()
    {
        //Print out all variables
        Debug.Log("My name is " + myName);
        Debug.Log("My age is " + myAge);
        Debug.Log("My speed is " + mySpeed);
        Debug.Log("Health: " + myHealth);
        Debug.Log("Score: " + myScore);
        Debug.Log("Has all keys = " + hasAllKeys);
        Debug.Log("Ammo: " + ammoCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
