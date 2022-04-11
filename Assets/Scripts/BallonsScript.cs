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
    [SerializeField]
    private GameObject ballons;
    [HideInInspector]
    public ScoreController ScoreController;

    // Update is called once per frame
    void Update()
    {
        BallonsMove();


    }
    private void GenerateBallons()
    {
        Instantiate(ballons.gameObject, new Vector2(20, 1), Quaternion.identity);

    }

    public void BallonsMove()
    {
        ballons.transform.position = new Vector2((ballons.transform.position.x + move.x * Speed * Time.deltaTime),

                                              ballons.transform.position.y);


        if (ballons.transform.position.x < -20)
        {
            GenerateBallons();
            Destroy(ballons.gameObject);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerView>())
        {
            Debug.Log("Collisionoccur btwn ballon and player");
            
            GenerateBallons();
            BallonsMove();
            Destroy(ballons.gameObject);
            ScoreController.IncreaseScore(10);
        }
    }




}
