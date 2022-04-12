using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : PlayerStates
{

    public override void OnEnterState()
    {
        base.OnEnterState();

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DoJump();
        }
        else if (playerStates.runSpeed != 0)
        {
            playerView.ChangeState(playerView.playerRunning);
        }
        else if(playerStates.runSpeed == 0)
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
        playerView.isGrounded = GroundState.grounded;
        playerView.doJump = JumpState.notJumped;
        if (playerView.isGrounded == GroundState.grounded && playerView.doJump == JumpState.notJumped)
        {
            JumpAnimation(GroundState.notgrounded);
            playerView.rigidBody.velocity = Vector2.up * playerView.jumpForce;
        }
    }

    public void JumpAnimation(GroundState state )
    {
     
        if (playerView.isGrounded != state)
        {
            playerView.animator.SetBool("jump", true);
        }
        else
        {
            playerView.animator.SetBool("jump", false);
        }
            
    }
}
