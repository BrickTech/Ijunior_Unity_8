using UnityEngine;

public class ScaleMutation : MonoBehaviour
{
    [SerializeField] private float _mutationSpeed;

    private Vector3 _delta;

    private void Update()
    {
        _delta = new Vector3(_mutationSpeed, _mutationSpeed, _mutationSpeed);
        transform.localScale += _delta * Time.deltaTime;
    }
}
