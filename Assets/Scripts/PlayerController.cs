using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
    
{
    private Rigidbody2D rigidBody;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    Animator animator;

    private bool isGrounded = false;

    public bool IsGrounded { get => isGrounded; set => isGrounded = value; }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       
    }


    private void FixedUpdate()
    {
        bool doJump = Input.GetMouseButtonDown(0);
        if (isGrounded)
        {
            if (doJump)
            {
                JumpAnimation(true);
                rigidBody.velocity = Vector2.up * jumpForce;
            }
        }
        
    }

    public void JumpAnimation(bool value)
    {
        isGrounded = !value;
        if (value)
            animator.SetBool("jump", true);
        else
            animator.SetBool("jump", false);
    }

   
}
