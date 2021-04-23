using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //Bill is 40
    //Tip is 20% or based on what the user wants
    //Calculate total amount

    public int billAmount = 40;
    public float tipPercentage = 20.0f;
    public float tipAmount;
    public float totalAmount;

    // Start is called before the first frame update
    void Start()
    {
        tipAmount = billAmount * (tipPercentage / 100);
        totalAmount = billAmount + tipAmount;

        //Your bill is: and your tip amount is: so you owe:

        Debug.Log("Your bill is: " + billAmount + " and your tip amount is: " + tipAmount + " so you owe: " + totalAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
