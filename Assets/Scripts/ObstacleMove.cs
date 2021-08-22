using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    Vector2 move = Vector2.left;
    [SerializeField]
    private float speed;

    public float Speed { get => speed; }

    // Update is called once per frame
    void Update()
    {

        this.transform.position = new Vector2((this.transform.position.x + move.x * Speed * Time.deltaTime),

                                               this.transform.position.y);
        
    }


}
