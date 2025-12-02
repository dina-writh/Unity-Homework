using UnityEngine;

public class MoveRotateGrow : MonoBehaviour
{
    [SerializeField] private float _speed = 100f;
    [SerializeField] private float _growSpeed = 100f; 
    [SerializeField] private float _rotationSpeed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        transform.localScale += Vector3.one * _growSpeed * Time.deltaTime;
    }
}
