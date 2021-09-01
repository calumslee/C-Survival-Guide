using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDB : MonoBehaviour
{
    //Populated through inspector
    [SerializeField]
    private Customer[] customers;

    private void Start()
    {
        Debug.Log(customers[0].age);
    }

    //Populated through code

    /*private void Start()
    {
        CreateCustomer();
    }

    private void CreateCustomer()
    {
        Customer customer1 = new Customer("Calum", "Slee", 23, "Male", "Audio Engineer");

        //Debug.Log(customer1.firstName);
    }*/
}
