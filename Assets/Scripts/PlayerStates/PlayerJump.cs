using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : PlayerStates
{
    public override void OnEnterState()
    {
        base.OnEnterState();

    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DoJump();
        }
        else if (playerView.ObstacleMove.Speed != 0)
        {
            playerView.ChangeState(playerView.playerRunning);
        }
        else if(playerView.ObstacleMove.Speed == 0)
        {
            playerView.ChangeState(playerView.playerIdle);
        }

    }

    public override void OnExitState()
    {
        base.OnExitState();
    }

    public void DoJump()
    {
        playerView.doJump = Input.GetMouseButtonDown(0);

        if (playerView.isGrounded && playerView.doJump)
        {
            JumpAnimation(true);
            playerView.rigidBody.velocity = Vector2.up * playerView.jumpForce;
        }
    }

    //player jump animation
    public void JumpAnimation(bool value)
    {
        playerView.isGrounded = !value;
        if (value)
        {
            playerView.animator.SetBool("jump", true);
        }
        else
        {
            playerView.animator.SetBool("jump", false);
        }
            
    }
}
