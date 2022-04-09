using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonPool :GenericSingleton<BallonPool>
{
    public static BallonPool ballons;
    [SerializeField]
    GameObject ballonprefab;
    [SerializeField]
    int ballonRequire;

    List<GameObject> ballonsList;
    protected override void Awake()
    {
        ballons = this;
    }
    private void Start()
    {
        ballonsList = new List<GameObject>();
        for (int i =0; i< ballonRequire; i++)
        {
            GameObject ballons = (GameObject)Instantiate(ballonprefab);
            ballons.SetActive(false);
            ballonsList.Add(ballons);
        }
    }

    public GameObject GetPooledObject()
    {
        for(int i=0; i < ballonsList.Count; i++)
        {
            if (!ballonsList[i].activeInHierarchy)
            {
                return ballonsList[i];
            }
            
        }
        return null;
    }
}
