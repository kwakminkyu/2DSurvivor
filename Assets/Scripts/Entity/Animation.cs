using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator anim;
    private Movement movement;

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        movement = GetComponent<Movement>();
    }

    private void LateUpdate()
    {
        anim.SetFloat("Speed", movement.CurrentDirection().magnitude);
    }
}
