using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    
    private void Update()
    {
        transform.Rotate(0, _speed, 0);
    }
}
