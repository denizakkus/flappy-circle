using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoolableObjectsComponent : MonoBehaviour
{
    public void SendActiveObjectsToPool()
    {
        GameObject[] objects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        PoolableComponent poolableComponent;
        foreach (GameObject obj in objects)
        {
            poolableComponent = obj.gameObject.GetComponent<PoolableComponent>();

            if (poolableComponent)
            {
                poolableComponent.AddToPool();
            }
        }
    }
}
