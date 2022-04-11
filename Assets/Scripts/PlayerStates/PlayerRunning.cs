using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunning : PlayerStates
{
    public override void OnEnterState()
    {
        base.OnEnterState();

    }
    private void FixedUpdate()
    {
        if (playerView.ObstacleMove.Speed != 0)
        {
            Run();
        }
       else if (Input.GetMouseButtonDown(0))
        {
            playerView.ChangeState(playerView.playerJump);
        }
        else if (playerView.ObstacleMove.Speed == 0)
        {
            playerView.ChangeState(playerView.playerIdle);
        }

    }

    private void Run()
    {
        playerView.animator.SetBool("isrunning", true);
    }

    public override void OnExitState()
    {
        base.OnExitState();
    }
}
