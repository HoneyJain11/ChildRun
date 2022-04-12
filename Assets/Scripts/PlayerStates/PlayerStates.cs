using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
    public static PlayerStates playerStates;
    [SerializeField]
    GameObject obstaclesMove;
    [HideInInspector]
    public float runSpeed;
    protected PlayerView playerView;

    void Awake()
    {
        playerStates = this;
        playerView = GetComponent<PlayerView>();
        runSpeed = obstaclesMove.GetComponent<ObstacleMove>().Speed;
    }
    
    public virtual void OnEnterState()
    {
        this.enabled = true;
    }

    public virtual void OnExitState()
    {
        this.enabled = false;
    }
}
