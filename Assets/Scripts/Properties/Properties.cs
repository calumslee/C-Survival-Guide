using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    Properties _test = new Properties();

    private void Access()
    {
        //Can get and set
        _test.MyName = "Calum";

        //Can only get
        float speed = _test.Speed;
    }
}

public class Properties : MonoBehaviour
{
    //Create properties for the following
    //Speed (Read Only)
    //Name (Public


    //Auto Properties
    //public float speed { get; private set; }

    //public string myName { get; set; }

    //Defined Properties
    private float _speed;
    public float Speed
    {
        get
        {
            return _speed;
        }
        private set
        {
            _speed = value;
        }
    }

    private string _myName;
    public string MyName
    {
        get
        {
            return _myName;
        }
        set
        {
            _myName = value;
        }
    }

    private void Start()
    {
        Speed = 10f;
        MyName = "Calum";

        Debug.Log(MyName + Speed);
    }
}
