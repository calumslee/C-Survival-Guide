using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    [SerializeField]
    private int _weaponID;

    //ID 1 = Gun
    //ID 2 = Knife
    //ID 3 = Machine Gun

    private void Update()
    {
        switch (_weaponID)
        {
            case 1:
                Debug.Log("Weapon Selected = Gun");
                break;
            case 2:
                Debug.Log("Weapon Selected = Knife");
                break;
            case 3:
                Debug.Log("Weapon Selected = Machine Gun");
                break;
            default:
                Debug.Log("You are unarmed");
                break;
        }
    }
}
