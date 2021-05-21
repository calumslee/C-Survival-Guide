using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLoop : MonoBehaviour
{
    //Create a program where you increment the value of speed by 5 every second.
    //When speed is greather than max speed (random between 60 and 120), stop incrementing
    //Hint: Coroutine

    [SerializeField]
    private int _speed;
    [SerializeField]
    private int _maxSpeed;

    private void Start()
    {
        _maxSpeed = Random.Range(60, 121);
        StartCoroutine(SpeedIncrement());
    }

    private IEnumerator SpeedIncrement()
    {
        while (_speed < _maxSpeed)
        {
            _speed += 5;
            yield return new WaitForSeconds(1.0f);
        }
    }
}

