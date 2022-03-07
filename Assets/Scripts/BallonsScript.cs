using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallonsScript : MonoBehaviour
{
    Vector2 move = Vector2.left;
    [SerializeField]
    private float speed;
    public float Speed { get => speed; set => speed = value; }
    public GameObject ballons;
    public ScoreController ScoreController;

    private void GenerateBallons()
    {

        {
            Debug.Log("Ballons generated");

            Instantiate(ballons.gameObject, new Vector2(10,1), Quaternion.identity);
        }

    }


    // Update is called once per frame
    void Update()
    {
        BallonsMove();


    }

    public void BallonsMove()
    {
        ballons.transform.position = new Vector2((ballons.transform.position.x + move.x * Speed * Time.deltaTime),

                                              ballons.transform.position.y);


        if (ballons.transform.position.x < -15)
        {
            GenerateBallons();
            Destroy(ballons.gameObject);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Collisionoccur btwn ballon and player");
            
            GenerateBallons();
            BallonsMove();
            Destroy(ballons.gameObject);
            ScoreController.IncreaseScore(10);
        }
    }




}
