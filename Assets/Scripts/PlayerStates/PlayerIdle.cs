using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle : PlayerStates
{

    public override void OnEnterState()
    {
        base.OnEnterState();

    }
    private void Update()
    {
        if (playerStates.runSpeed != 0)
        {
            playerView.ChangeState(playerView.playerRunning);
        }
       else if (Input.GetMouseButtonDown(0))
        {
            playerView.ChangeState(playerView.playerJump);
        }
        Idle();
    }

    private void Idle()
    {
         if (playerStates.runSpeed == 0)
            playerView.animator.SetBool("isrunning", false);
         else
         playerView.ChangeState(playerView.playerRunning);
    }

    public override void OnExitState()
    {
        base.OnExitState();
    }
}
