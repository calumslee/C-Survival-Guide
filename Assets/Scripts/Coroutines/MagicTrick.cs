using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicTrick : MonoBehaviour
{
    private bool _cubeActive;
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _cubeActive = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && _cubeActive == true)
        {
            StartCoroutine(InvisibleCube());
        }
    }

    private IEnumerator InvisibleCube()
    {
        _meshRenderer.enabled = false;
        _cubeActive = false;
        yield return new WaitForSeconds(5.0f);
        _meshRenderer.enabled = true;
        _cubeActive = true;
    }
}
