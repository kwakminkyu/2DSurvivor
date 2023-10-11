using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private Movement movement;

    private void Awake()
    {
        movement = GetComponent<Movement>();
    }

    private void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>().normalized;
        movement.Move(direction);
    }
}
