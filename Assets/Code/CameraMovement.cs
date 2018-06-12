using UnityEngine;
using Jailbreak.Core;
using System.Collections;

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
        // Debug.Log("Look Angle: " + _lookAngle);
        Debug.Log("Input mouse Y: " + _input.MouseY);
        _lookAngle = Mathf.Clamp(_lookAngle - _input.MouseY, -50, 50);
        transform.localRotation = Quaternion.Euler(_lookAngle, 0, 0);
    }
}

