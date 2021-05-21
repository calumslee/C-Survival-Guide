using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayForEachLoop : MonoBehaviour
{
    [SerializeField]
    private string[] _itemName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var item in _itemName)
            {
                if (item == "Sword")
                {
                    Debug.Log(item + " Exists!");
                }
            }
        }
    }
}
