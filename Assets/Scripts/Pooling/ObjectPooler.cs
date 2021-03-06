using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectPooler : GenericSingleton<ObjectPooler>
{
    [System.Serializable]
    public class ObjectPoolItem
    {
        public int itemRequire;
        public GameObject objectPrefab;
        
    }

   public List<ObjectPoolItem> objectPoolItems;
   List<GameObject> pooledRequireObjects;

    private void Start()
    {
        pooledRequireObjects = new List<GameObject>();
        foreach(ObjectPoolItem poolItem in objectPoolItems)
        {
            for (int i = 0; i < poolItem.itemRequire; i++)
            {
                GameObject gameObject = (GameObject)Instantiate(poolItem.objectPrefab);
                gameObject.SetActive(false);
                pooledRequireObjects.Add(gameObject);
            }
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledRequireObjects.Count; i++)
        {
            if (!pooledRequireObjects[i].activeInHierarchy && pooledRequireObjects[i].GetComponent<BallonsScript>())
            {
                return pooledRequireObjects[i];
            }
            if (!pooledRequireObjects[i].activeInHierarchy && pooledRequireObjects[i].GetComponent<ObstacleMove>())
            {
                return pooledRequireObjects[i];
            }


        }
        return null;
    }
}
