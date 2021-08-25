using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBgController : MonoBehaviour
{
    Vector2 move=Vector2.left;
    [SerializeField]
    private float speed;

    public float Speed { get => speed; set => speed = value; }

    // Update is called once per frame
    void Update()
    {
        MoveBackground(Speed);
    }

    public void MoveBackground(float speed)
    {
        this.transform.position = new Vector2((this.transform.position.x +
            move.x * Speed * Time.deltaTime), this.transform.position.y);
        if (this.transform.position.x < -54)
        {
            this.transform.position = new Vector2(0, 0);
        }
    }


}
 