using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 move=Vector2.left;
    public float speed;

    // Update is called once per frame
    void Update()
    {
      
        this.transform.position = new Vector2((this.transform.position.x + move.x * speed * Time.deltaTime),

                                               this.transform.position.y);
        if (this.transform.position.x < -52.4)
        {
            this.transform.position = new Vector2(0,0);
        }
        



        


    }
}
 