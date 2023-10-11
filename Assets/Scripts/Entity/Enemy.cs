using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Movement movement;
    private Rigidbody2D _rigidbody;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        movement = GetComponent<Movement>();
        _rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Vector2 directon = GameManager.instance.player.transform.position - transform.position;
        movement.Move(directon.normalized);
    }
}
