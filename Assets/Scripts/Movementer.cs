using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementer : MonoBehaviour
{
    private float _speed = 0.5f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
