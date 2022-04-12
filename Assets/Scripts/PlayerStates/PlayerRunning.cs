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
    private void Update()
    {
         if (Input.GetMouseButtonDown(0))
        {
            playerView.ChangeState(playerView.playerJump);
        }
        else if (playerStates.runSpeed == 0)
        {
            playerView.ChangeState(playerView.playerIdle);
        }
        Run();
        
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
