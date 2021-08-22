using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacles;

    private void Start()
    {
        GenerateObstaclesPrefab();
        Debug.Log("obstacle generated");
    }
    private void GenerateObstaclesPrefab()
    {
        StartCoroutine(GenerateObstacles());
    }
    IEnumerator GenerateObstacles()
        {

            yield return new WaitForSeconds(UnityEngine.Random.Range(0,10));
            Instantiate(obstacles, new Vector2(11, -4), Quaternion.identity);
    }

    private void Update()
    {
        if (obstacles.transform.position.x < -54)
        {
            Destroy(obstacles.gameObject);

        }
    }
    

    
}
