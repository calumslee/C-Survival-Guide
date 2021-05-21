using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticalArrayLoop : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _cubes;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*foreach (var cube in _cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.red;
            }*/

            //Convert the above to a for loop
            for (int i = 0; i < _cubes.Length; i++)
            {
                _cubes[i].GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
    }
}
