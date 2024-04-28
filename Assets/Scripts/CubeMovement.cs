using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private float _mutationSpeed = 0.1f;
    private float _speed = 1f;
    private float _rotationSpeed = 50f;
    
    private Vector3 _delta;

    private void Update()
    {
        Mutate();
        Rotate();
        Move();
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }

    private void Mutate()
    {
        _delta = new Vector3(_mutationSpeed, _mutationSpeed, _mutationSpeed);
        transform.localScale += _delta * Time.deltaTime;
    }

    private void Move()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
