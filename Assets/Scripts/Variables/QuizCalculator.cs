﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float quiz1, quiz2, quiz3, quiz4, quiz5;

    //Create a program that calculates random quiz grades and prints the average

    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(0f, 100f);
        quiz2 = Random.Range(0f, 100f);
        quiz3 = Random.Range(0f, 100f);
        quiz4 = Random.Range(0f, 100f);
        quiz5 = Random.Range(0f, 100f);

        float average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

        average = Mathf.Round((average * 100f) / 100f);

        Debug.Log("Average: " + average);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
