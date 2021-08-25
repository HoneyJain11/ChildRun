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
    [SerializeField]
    private ObstacleMove ObstacleMove;

    [SerializeField]
    private ParallaxBgController parallaxBgController;

    private bool isGrounded = false;
    public bool doJump = false;

    public bool IsGrounded { get => isGrounded; set => isGrounded = value; }
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        
    }
   
    private void FixedUpdate()
    {
        doJump = Input.GetMouseButtonDown(0);

        if (isGrounded && doJump)
        {
       
            
                JumpAnimation(true);
                rigidBody.velocity = Vector2.up * jumpForce;

            
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("collision occur between player and obstacles");
            animator.SetBool("isrunning", false);
            collision.gameObject.GetComponent<ObstacleMove>().Speed = 0;
            parallaxBgController.GetComponent<ParallaxBgController>().Speed=0;


        }
     }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<ObstacleMove>().Speed = 10;
        parallaxBgController.GetComponent<ParallaxBgController>().Speed = 10;
        animator.SetBool("isrunning", true);

    }
}
