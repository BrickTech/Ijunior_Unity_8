using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMutation : MonoBehaviour
{
    [SerializeField] private float _mutationSpeed;
    private Vector3 _delta;

    private void Update()
    {
        _delta = new Vector3(_mutationSpeed, _mutationSpeed, _mutationSpeed);
        transform.localScale += _delta * Time.deltaTime;
    }
}
