using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotate : MonoBehaviour
{
    [SerializeField] private float _growSpeed = 100f;

    private void Update()
    {
        transform.localScale += Vector3.one * _growSpeed * Time.deltaTime;
    }
}
