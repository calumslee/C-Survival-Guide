using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(NameRoutine());
    }

    private IEnumerator NameRoutine()
    {
        yield return new WaitForSeconds(3.0f);
        Debug.Log("Calum");
        yield return new WaitForSeconds(3.0f);
        Debug.Log("Stella");
    }
}
