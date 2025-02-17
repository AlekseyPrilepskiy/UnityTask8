using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    
    void Update()
    {
        transform.Rotate(0, _speed, 0);
    }
}
