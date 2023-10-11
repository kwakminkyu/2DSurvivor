using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private SpriteRenderer spriteRenderer;

    private Vector2 moveDirection;

    [SerializeField] private float speed;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        ApplyMovement(moveDirection);
    }

    private void LateUpdate()
    {
        Rotate();
    }

    public void Move(Vector2 direction)
    {
        moveDirection = direction;
    }

    private void ApplyMovement(Vector2 moveDirection)
    {
        moveDirection = moveDirection * speed;
        _rigidbody.velocity = moveDirection;
    }

    private void Rotate()
    {
        if (moveDirection.x != 0)
        {
            spriteRenderer.flipX = moveDirection.x < 0;
        }
    }

    public Vector2 CurrentDirection()
    {
        return moveDirection;
    }
}
