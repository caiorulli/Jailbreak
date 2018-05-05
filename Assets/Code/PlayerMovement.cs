using UnityEngine;
using System.Collections;
using Jailbreak.Core;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private CharacterController _controller;
    private UnityInput _input;

    void Start()
    {
        _input = new UnityInput();
    }
    
    void Update()
    {
        Vector3 movement = new Vector3(_input.HorizontalAxis, -1, _input.VerticalAxis);
        _controller.Move(transform.TransformDirection(movement) * 10 * Time.deltaTime);
        transform.Rotate(new Vector3(0, _input.MouseX, 0));
    }
}
