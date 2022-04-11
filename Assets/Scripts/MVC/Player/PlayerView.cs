using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
   public PlayerController playerController;
    [HideInInspector]
    public Rigidbody2D rigidBody;
    public float jumpForce;
    public Animator animator;
    public ObstacleMove ObstacleMove;
    public ParallaxBgController parallaxBgController;
    public bool doJump = false;
    public bool isGrounded = false;


    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void SetPlayerControllerReference(PlayerController controller)
    {
        playerController = controller;
    }

    private void FixedUpdate()
    {
       if (Input.GetMouseButtonDown(0))
        {
            playerController.DoJump();
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerController.DetectCollision(collision);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        playerController.AfterCollisionWork(collision);
    }

    private void OnDisable()
    {
        playerController.UnsubscribeEvent();
    }
}
