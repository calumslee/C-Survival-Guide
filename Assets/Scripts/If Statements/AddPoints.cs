using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    //Variable to store points
    [SerializeField]
    private int _score;

    //hasSaidMessage variable to check
    private bool _hasSaidMessage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If we hit the space key
        //Add 10 points

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
        }

        //If score is greater than or equal to 50 AND && hasSaidMessage is false
        //Print you are awesome
        //Change hasSaidMessage to true

        if (_score >= 50 && _hasSaidMessage == false)
        {
            Debug.Log("You are awesome!");
            _hasSaidMessage = true;
        }
    }
}
