using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PipeSpawnerComponent : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float height;

    PoolableComponent poolableComponent;

    private void Awake()
    {
        poolableComponent = pipePrefab.gameObject.GetComponent<PoolableComponent>();
    }

    public void SpawnPipe()
    {
        GameObject obj;
        /*
        obj = PoolManager.Instance.GetFromPool(poolableComponent.GetPoolableType());
        SetPipePositionRandomly(obj, 21);

        obj = PoolManager.Instance.GetFromPool(poolableComponent.GetPoolableType());
        SetPipePositionRandomly(obj, 30);

        obj = PoolManager.Instance.GetFromPool(poolableComponent.GetPoolableType());
        SetPipePositionRandomly(obj, 39);
        */

        obj = PoolManager.Instance.GetFromPool(poolableComponent.GetPoolableType());
        SetPipePositionRandomly(obj, 21);

        obj = PoolManager.Instance.GetFromPool(poolableComponent.GetPoolableType());
        SetPipePositionRandomly(obj, 30);

    }

    private void SetPipePositionRandomly(GameObject obj, int xPosition)
    {
        obj.transform.position = new Vector3(xPosition, Random.Range(-height, height), 0);
    }



}
