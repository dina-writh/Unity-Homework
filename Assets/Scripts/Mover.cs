using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition = new Vector3(-5.53f, 8.513f, 0.42f);  
    [SerializeField] private Vector3 _endPosition = new Vector3(4f, 8.513f, 0.42f);
    [SerializeField] private int _stepCount = 10;
    private void Start()
    {
        foreach (Vector3 position in EnumeratePosition(_startPosition, _endPosition, _stepCount));
    }

    private IEnumerable<Vector3> EnumeratePosition(Vector3 start, Vector3 end, int steps)
    {
        Vector3 distans = start - end;
        Vector3 stepValur = distans / steps;
        Vector3 currentStep = stepValur;

        for (int step = 1; step <= steps; step++)
        {
            currentStep = stepValur * step;
            yield return start - currentStep;
        }
    }
}
