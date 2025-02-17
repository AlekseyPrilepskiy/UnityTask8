using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    private float _speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, _speed * Time.deltaTime);
    }
}
