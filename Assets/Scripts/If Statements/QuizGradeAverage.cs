using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGradeAverage : MonoBehaviour
{
    //5 quiz grades

    [SerializeField]
    private float _quiz1, _quiz2, _quiz3, _quiz4, _quiz5;
    [SerializeField]
    private float _average;

    // Start is called before the first frame update
    void Start()
    {
        _quiz1 = Random.Range(1, 101);
        _quiz2 = Random.Range(1, 101);
        _quiz3 = Random.Range(1, 101);
        _quiz4 = Random.Range(1, 101);
        _quiz5 = Random.Range(1, 101);

        //Calculate the average

        _average = (_quiz1 + _quiz2 + _quiz3 + _quiz4 + _quiz5) / 5;
        _average = Mathf.Round(_average * 100f) / 100f;

        //Print out the grade average based on
        //A = >= 90
        //B = >= 80 but less than 90
        //C = >= 70 <80
        //F = < 70

        if (_average >= 90)
        {
            Debug.Log("Average Grade: A");
        }
        else if (_average >= 80 && _average < 90)
        {
            Debug.Log("Average Grade: B");
        }
        else if (_average >= 70 && _average < 80)
        {
            Debug.Log("Average Grade: C");
        }
        else if (_average < 70)
        {
            Debug.Log("Average Grade: F");
        }
        else
        {
            Debug.Log("Error in calculating average grade");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
