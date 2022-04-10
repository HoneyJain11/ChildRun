using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventHandler : GenericSingleton<EventHandler>
{
    public event Action OnBallonBurst;
    public event Action FallOnObstacle;

    public void InvokeOnBallonBurstEvent()
    {
        OnBallonBurst?.Invoke();
    }

    public void InvokeFallOnObstacle()
    {
        FallOnObstacle?.Invoke();
    }


}
