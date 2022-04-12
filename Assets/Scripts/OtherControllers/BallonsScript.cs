using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        GameObject ballonObject = ObjectPooler.Instance.GetPooledObject();
        
        if (ballonObject != null)
        {
            ballonObject.transform.position = new Vector2(20, 1);
            ballonObject.transform.rotation = Quaternion.identity;
            ballonObject.SetActive(true);
        }
       
    }

    private void GiveBallonPostion( )
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
            ballons.SetActive(false);
            EventHandler.Instance.InvokeOnBallonBurstEvent();
            GiveBallonPostion();
            ballons.SetActive(true);
            
            
        }
    }

}
