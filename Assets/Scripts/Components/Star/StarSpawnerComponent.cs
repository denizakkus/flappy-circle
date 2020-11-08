using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawnerComponent : MonoBehaviour
{
    [SerializeField] private GameObject backStarPrefab;
    [SerializeField] private GameObject middleStarPrefab;
    [SerializeField] private GameObject FrontStarPrefab;

    PoolableComponent backStarPoolableComponent;
    PoolableComponent middleStarPoolableComponent;
    PoolableComponent frontStarPoolableComponent;

    private void Awake()
    {
        backStarPoolableComponent = backStarPrefab.GetComponent<PoolableComponent>();
        middleStarPoolableComponent = middleStarPrefab.GetComponent<PoolableComponent>();
        frontStarPoolableComponent = FrontStarPrefab.GetComponent<PoolableComponent>();
    }

    public void SpawnStar()
    {
        
    }

    public void SpawnBackStar ()
    {
        GameObject obj;
        obj = PoolManager.Instance.GetFromPool(backStarPoolableComponent.GetPoolableType());
        obj.transform.position = new Vector3(33, 5, 6);
    }

    public void SpawnMiddleStar()
    {
        GameObject obj;
        obj = PoolManager.Instance.GetFromPool(middleStarPoolableComponent.GetPoolableType());
        obj.transform.position = new Vector3(33, 5, 6);
    }

    public void SpawnFrontStar()
    {
        GameObject obj;
        obj = PoolManager.Instance.GetFromPool(frontStarPoolableComponent.GetPoolableType());
        obj.transform.position = new Vector3(33, 5, 6);
    }
}
