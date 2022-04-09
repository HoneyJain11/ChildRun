﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController 
{
    public PlayerView playerView;
    public PlayerModel playerModel;

    public PlayerController(PlayerModel playerModel, PlayerView playerprefab)
    {
        this.playerModel = playerModel;
        playerView = GameObject.Instantiate<PlayerView>(playerprefab);
    }

    //Player jumping phsyics
    public void DoJump() 
    {
        playerView.doJump = Input.GetMouseButtonDown(0);
        
        if (playerView.isGrounded && playerView.doJump)
        {
            Debug.Log("PlayerJumped");
            JumpAnimation(true);
            playerView.rigidBody.velocity = Vector2.up * playerView.jumpForce;
        }
    }

    //player jump animation
    public void JumpAnimation(bool value)
    {
        playerView.isGrounded = !value;
        if (value)
            playerView.animator.SetBool("jump", true);
        else
            playerView.animator.SetBool("jump", false);
    }

    public void DetectCollision(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ObstacleMove>())
        {
            Debug.Log("collision occur between player and obstacles");
            playerView.animator.SetBool("isrunning", false);
            collision.gameObject.GetComponent<ObstacleMove>().Speed = 0;
            playerView.parallaxBgController.Speed = 0;

        }

    }

    public void AfterCollisionWork(Collision2D collision)
    {
        playerView.animator.SetBool("isrunning", true);
        if(collision.gameObject.GetComponent<ObstacleMove>())
        {
            collision.gameObject.GetComponent<ObstacleMove>().Speed = 10;
            playerView.parallaxBgController.Speed = 10;
        }
        

    }
}