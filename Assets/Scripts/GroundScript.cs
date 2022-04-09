using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
 
    PlayerView playerView;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerView = collision.gameObject.GetComponent<PlayerView>();
        if (playerView)
        {
            playerView.isGrounded = true;
            playerView.playerController.JumpAnimation(!playerView.isGrounded);
        }
    }

}
