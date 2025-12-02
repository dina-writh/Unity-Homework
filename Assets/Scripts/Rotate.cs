using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 5f;

    private void Update()
    {
            transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }
}
