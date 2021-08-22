using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    PlayerController PlayerController;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController = collision.gameObject.GetComponent<PlayerController>();
        if (PlayerController)
        {
            PlayerController.IsGrounded = true;
            PlayerController.JumpAnimation(!PlayerController.IsGrounded);
        }
    }

}
