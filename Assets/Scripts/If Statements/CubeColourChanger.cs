using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CubeColourChanger : MonoBehaviour
{
    public GameObject cube;
    private Material _material;

    [SerializeField]
    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        //At the start of the program, turn the cube red.

        _material = cube.GetComponent<Renderer>().material;
        _material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        //When you hit the space key, you increment a score value.

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _score += 10;
        }

        //When value is greater than 50, turn the cube Green.

        if (_score > 50)
        {
            _material.color = Color.green;
        }
    }
}
