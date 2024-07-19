using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Experimental.GraphView.GraphView;

public class playerControl : MonoBehaviour
{
    [SerializeField]
    private Vector2 _moveinput = Vector2.zero;
    [SerializeField]
    private CharacterController _characterController;
    [SerializeField]
    private float _speed = 40f;

    private float _x, _y;
    public void move(InputAction.CallbackContext context)
    {
        _moveinput = context.ReadValue<Vector2>();
        if (_moveinput != Vector2.zero)
        {
            _x = _moveinput.x;
            _y = _moveinput.y;
        }
    }
    void Update()
    {
        if (_moveinput != Vector2.zero)
        {
            Vector3 movement = new Vector3(_x, 0, _y);
            Vector3 moving = movement * _speed * Time.deltaTime;
            _characterController.Move(moving);
        }
    }
}
