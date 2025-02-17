using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _growthSpeed = 0.3f;
    [SerializeField] private Vector3 _maxScale = new Vector3(3f, 3f, 3f);

    private void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _maxScale, _growthSpeed * Time.deltaTime);
    }
}
