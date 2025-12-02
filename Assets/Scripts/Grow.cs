using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _growSpeed = 100f;

    private void Update()
    {
        transform.localScale += Vector3.one * _growSpeed * Time.deltaTime;
    }
}
