using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseToSwitch : MonoBehaviour
{
    [SerializeField]
    private int _points;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            _points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _points = 0;
        }

        /*if (_points == 50)
        {
            Debug.Log("Points are 50!");
        }
        else if (_points == 100)
        {
            Debug.Log("Points are 100!");
        }
        else
        {
            Debug.Log("You need 50 or 100 points to receive a message");
        }*/

        switch (_points)
        {
            case 50:
                Debug.Log("Points are 50!");
                break;
            case 100:
                Debug.Log("Points are 100!");
                break;
            default:
                Debug.Log("You need 50 or 100 points to receive a message");
                break;
        }
    }
}
