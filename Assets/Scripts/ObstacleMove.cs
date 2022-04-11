using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    Vector2 move = Vector2.left;
    [SerializeField]
    private float speed;
    public float Speed { get => speed; set => speed = value; }
    [SerializeField]
    GameObject obstacles;

    private void Awake()
    {
        GenerateObstacles();
    }

    private void GenerateObstacles()
    {
        GameObject obstacles = ObjectPooler.Instance.GetPooledObject();

        if (obstacles != null)
        {
            obstacles.transform.position = new Vector2(20, -4);
            obstacles.transform.rotation = Quaternion.identity;
            obstacles.SetActive(true);
        }


    }

    void Update()
    {

        MoveObstacle();


    }

    private void MoveObstacle()
    {

        obstacles.transform.position = new Vector2((obstacles.transform.position.x + move.x * Speed * Time.deltaTime),

                                              obstacles.transform.position.y);


        if (obstacles.transform.position.x < -35)
        {
            obstacles.SetActive(false);
            obstacles.transform.position = new Vector2(20, -4);
            obstacles.transform.rotation = Quaternion.identity;
            obstacles.SetActive(true);

        }
    }

}
