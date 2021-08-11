using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    //Assign a cube in inspector
    //When Space key hit, object is passed into function called ChangeColor
    //Function takes in a object, and a color to change to, then handle the function

    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private Color _cubeColor;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColorFunction(_cube, _cubeColor);
        }
    }

    private void ChangeColorFunction(GameObject _obj, Color _colorToAssign)
    {
        _obj.GetComponent<MeshRenderer>().material.color = _colorToAssign;
    }
}
