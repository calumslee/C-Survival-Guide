using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorCoroutine : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private WaitForSeconds _colorChangeWait = new WaitForSeconds(3.0f);

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        StartCoroutine(ColorChange());
    }

    private IEnumerator ColorChange()
    {
        while (true)
        {
            yield return _colorChangeWait;
            _meshRenderer.material.color = Random.ColorHSV();
        }
    }
}
