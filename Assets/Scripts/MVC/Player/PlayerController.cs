using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController 
{
    public PlayerView playerView;
    public PlayerModel playerModel;

    public PlayerController(PlayerModel playerModel, PlayerView playerprefab)
    {
        this.playerModel = playerModel;
        playerView = GameObject.Instantiate<PlayerView>(playerprefab);
    }


    public void DetectCollision(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ObstacleMove>())
        { 
            EventHandler.Instance.InvokeFallOnObstacle();
            collision.gameObject.GetComponent<ObstacleMove>().Speed = 0;
            playerView.parallaxBgController.Speed = 0;

        }

    }

    public void UnsubscribeEvent()
    {
        EventHandler.Instance.OnBallonBurst -= IncreaseScore;
        EventHandler.Instance.FallOnObstacle -= DecreaseScore;
    }

    public void AfterCollisionWork(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<ObstacleMove>())
        {
            collision.gameObject.GetComponent<ObstacleMove>().Speed = 10;
            playerView.parallaxBgController.Speed = 8;
        }
    }

    public void SubscribeEvent()
    {
        EventHandler.Instance.OnBallonBurst += IncreaseScore;
        EventHandler.Instance.FallOnObstacle += DecreaseScore;
    }

    private void DecreaseScore()
    {
       ScoreController.scoreController.IncreaseScore(-5);
        
    }

    private void IncreaseScore()
    {
        ScoreController.scoreController.IncreaseScore(10);
       
    }
}
