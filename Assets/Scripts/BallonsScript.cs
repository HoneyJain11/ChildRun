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

    private void Awake()
    {
        GenerateBallons();
    }
    
    void Update()
    {
        BallonsMove();

    }
    private void GenerateBallons()
    {
        GameObject ballons = BallonPool.ballons.GetPooledObject();
        if (ballons != null)
        {
            ballons.transform.position = new Vector2(20, 1);
            ballons.transform.rotation = Quaternion.identity;
            ballons.SetActive(true);
        }
        
    }

    private void GiveBallonPostion()
    {
        
        ballons.transform.position = new Vector2(20, 1);
        ballons.transform.rotation = Quaternion.identity;
        
    }

    public void BallonsMove()
    {
        ballons.transform.position = new Vector2((ballons.transform.position.x + move.x * Speed * Time.deltaTime),

                                              ballons.transform.position.y);


        if (ballons.transform.position.x < -20)
        {
            
            ballons.SetActive(false);
            GiveBallonPostion();
            ballons.SetActive(true);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerView>())
        {
            Debug.Log("Collisionoccur btwn ballon and player");
            ballons.SetActive(false);
            ScoreController.scoreController.IncreaseScore(10);
            ballons.SetActive(true);
            GiveBallonPostion();

        }
    }




}
