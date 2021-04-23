using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChanger : MonoBehaviour
{
    [SerializeField]
    private int _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Increment speed when you hit 'S' key
        //'A' key decrements
        //You can't go below 0

        if (Input.GetKeyDown(KeyCode.S))
        {
            _speed += 5;
        }
        else if (Input.GetKeyDown(KeyCode.A) && _speed > 0)
        {
            _speed -= 5;
        }

        //When the speed is greater than 20 print "Slow down"
        //When speed is 0 print out "Speed up"

        if (_speed == 0)
        {
            Debug.Log("Speed up");
        }
        else if (_speed > 20)
        {
            Debug.Log("Slow down");
        }
    }
}
