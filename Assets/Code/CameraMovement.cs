using UnityEngine;
using Jailbreak.Core;

public class CameraMovement: MonoBehaviour
{
    private UnityInput _input;
    private float _lookAngle;

    void Start()
    {
        _input = new UnityInput();
        _lookAngle = 0;
    }

    void Update()
    {
        _lookAngle = Mathf.Clamp(_input.MouseY, -50, 50);
        transform.localRotation = Quaternion.Euler(_lookAngle, 0, 0);
    }
}

