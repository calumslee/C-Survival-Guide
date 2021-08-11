using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionArray : MonoBehaviour
{
    //Create array of 5 different positions
    //Custom method to generate random index
    //Custom method to set position to that index

    [SerializeField]
    private Vector3[] _positions;

    private void Start()
    {
        int _randomIndex = GenerateIndex();

        SetPosition(_randomIndex);
    }

    private int GenerateIndex()
    {
        return Random.Range(0, _positions.Length);
    }

    private void SetPosition(int _index)
    {
        transform.position = _positions[_index];
    }
}
