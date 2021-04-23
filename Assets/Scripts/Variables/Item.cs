using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Every item has a name
    //Every item has a description
    //Every item has an image icon
    //Every item has an attack strength

    public string itemName;
    public string description;
    public Sprite image;
    public float attackStrength;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Name: " + itemName);
        Debug.Log("Description: " + description);
        Debug.Log("Attack strength: " + attackStrength);
    }
}
