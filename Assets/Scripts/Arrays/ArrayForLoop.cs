using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayForLoop : MonoBehaviour
{
    [SerializeField]
    private int[] _itemID;
    [SerializeField]
    private string[] _itemName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < _itemName.Length; i++)
            {
                if (_itemName[i] == "Sword")
                {
                    Debug.Log("Sword Exists!");
                    Debug.Log("Item ID: " + _itemID[i]);
                }
            }
        }
    }
}
