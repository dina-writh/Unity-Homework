using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 5f;

    private void Update()
    {
            transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }
}
