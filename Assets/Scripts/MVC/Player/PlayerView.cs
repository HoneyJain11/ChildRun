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
    [HideInInspector]
    public PlayerStates currentState;
    public PlayerStates activeState;
    public PlayerRunning playerRunning;
    public PlayerJump playerJump;
    public PlayerIdle playerIdle;


    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        ChangeState(activeState);
    }

    public void SetPlayerControllerReference(PlayerController controller)
    {
        playerController = controller;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerController.DetectCollision(collision);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        playerController.AfterCollisionWork(collision);
    }

    public void ChangeState(PlayerStates newState)
    {
        if(currentState != null)
        {
            currentState.OnExitState();

        }
        currentState = newState;
        currentState.OnEnterState();
    }

    private void OnDisable()
    {
        playerController.UnsubscribeEvent();
    }
}
