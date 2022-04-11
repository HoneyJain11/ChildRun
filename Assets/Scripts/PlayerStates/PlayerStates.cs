using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
    protected PlayerView playerView;

    private void Awake()
    {
        playerView = GetComponent<PlayerView>();
    }
    private void Start()
    {
        
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
