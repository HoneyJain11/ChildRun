using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    Vector2 move = Vector2.left;

    [SerializeField]
    private float speed;
    public float Speed { get => speed; set => speed = value; }
    public GameObject obstacles;
   
    
     private void GenerateObstacles()
    {

        {
            Debug.Log("obstacle generated");
           
            Instantiate(obstacles.gameObject, new Vector2(20, -4), Quaternion.identity);
        }

    }


    // Update is called once per frame
    void Update()
    {

        obstacles.transform.position = new Vector2((obstacles.transform.position.x + move.x * Speed * Time.deltaTime),

                                               obstacles.transform.position.y);

        
       if (obstacles.transform.position.x < -35)
         {
            GenerateObstacles();
            Destroy(obstacles.gameObject);
            
        }
        
    }

    


}
