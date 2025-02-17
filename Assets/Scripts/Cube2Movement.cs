using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRotatingGrowingCube : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _rotationSpeed = 30f;
    [SerializeField] private float _growthSpeed = 0.1f;

    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;

        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);

        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
}

