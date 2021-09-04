using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Create private instance
    //Create public property to reference instance
    //Null check
    //Return private instance

    //Assign instance on awake

    private static SpawnManager _instance;
    public static SpawnManager Instance
    {
        get
        {
            if (_instance == null) Debug.LogError("Spawn Manager is NULL!");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void StartSpawning()
    {
        Debug.Log("Starting spawning");
    }
}
