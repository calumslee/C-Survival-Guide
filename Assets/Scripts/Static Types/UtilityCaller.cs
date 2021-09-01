using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityCaller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color randomColor = Random.ColorHSV();
            ColorChangeUtility.ChangeColor(this.gameObject, randomColor);
        }
    }
}
