using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorChangeUtility
{
    public static void ChangeColor(GameObject obj, Color col)
    {
        obj.GetComponent<MeshRenderer>().material.color = col;
    }
}
