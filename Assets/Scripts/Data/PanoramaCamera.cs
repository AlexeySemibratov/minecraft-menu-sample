using Random = System.Random;
using UnityEngine;

public class PanoramaCamera : MonoBehaviour
{
    private const int MinAngle = 0;
    private const int MaxAngle = 360;

    [SerializeField]
    private Transform _cameraTransform;

    [SerializeField]
    private float _rotationSpeed = 1.0f;

    private Random _random = new();

    private bool _isRotated = false;

    public void StartRotation()
    {
        int randomAngle = _random.Next(MinAngle, MaxAngle);
        _cameraTransform.rotation = Quaternion.AngleAxis(randomAngle, Vector3.up);

        _isRotated = true;
    }

    public void StopRotation()
    {
        _isRotated = false;
    }

    private void Update()
    {
        if (_isRotated == false)
            return;

        _cameraTransform.Rotate(0f, _rotationSpeed * Time.deltaTime, 0f);
    }
}
