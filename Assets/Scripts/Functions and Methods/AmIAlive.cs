using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmIAlive : MonoBehaviour
{
    //Create a program to check if dead or not.
    //When Space Key hit, damage the player by random amount.
    //If health is < 1. Print "The Player has died!"

    //Bonus: Prevent the damage function from being called once player is dead
    //No Negative health values

    [SerializeField]
    private int _health = 100;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _health > 0)
        {
            DamagePlayer(Random.Range(7, 23));
        }
    }

    private void DamagePlayer(int _damage)
    {
        _health -= _damage;
        
        if (_health <= 0)
        {
            _health = 0;
            Debug.Log("The Player has died!");
        }
    }
}
