using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeSwitch : MonoBehaviour
{
    //Create a program that turns a cube different colors based on user input
    //1 Key = blue
    //2 Key = red
    //3 Key = green
    //4 Key = black

    private MeshRenderer _mesh;
    private int _color;

    private void Start()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _color = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _color = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _color = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _color = 4;
        }

        switch (_color)
        {
            case 1:
                _mesh.material.color = Color.blue;
                break;
            case 2:
                _mesh.material.color = Color.red;
                break;
            case 3:
                _mesh.material.color = Color.green;
                break;
            case 4:
                _mesh.material.color = Color.black;
                break;
            default:
                _mesh.material.color = Color.white;
                break;
        }
    }
}
