﻿using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using TMPro;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private class Pool 
    {
        // the class holds prefabs that
        // you want to be thrown into the pool.
        public GameObject prefab;
        public Stack<GameObject> pool;

        // create a pool for prefab.
        public Pool(GameObject prefab)
        {
            this.prefab = prefab;
            pool = new Stack<GameObject>();
        }

        // get objects from the pool.
        public GameObject GetFromPool()
        {
            GameObject obj = null;

            if (pool.Count == 0)
            {
                obj = Instantiate(prefab);
            }
            else
            {
                obj = pool.Pop();
                obj.SetActive(true);
            }
            return obj;
        }

        // add objects to the pool
        public void AddToPool(GameObject obj)
        {
            obj.SetActive(false);
            pool.Push(obj);
        }
    }

    #region decleration
    // There is a ScriptalbeObject holds which prefab is which type.
    [SerializeField] PoolableTypePrefabMap poolableTypePrefabMap;

    // Singleton, PoolManager should be unique.
    public static PoolManager Instance;
    
    // a dictionary that holds pools.
    private  Dictionary<PoolableTypes, Pool> poolDictionary;
    #endregion

    private Dictionary<PoolableTypes, Queue<GameObject>> activeObjects;


    private void Awake()
    {
        // If instance already created, return.
        if (Instance) return;

        #region definition
        Instance = this;
        poolDictionary = new Dictionary<PoolableTypes, Pool>();
        #endregion
        activeObjects = new Dictionary<PoolableTypes, Queue<GameObject>>();

        // Create a pool for each prefabs which is specified in ScriptableObject
        foreach (PoolableTypePrefabMap.PoolableTypePrefabTuple tuple
                in poolableTypePrefabMap.poolableTypePrefabTuples)
        {
            Pool pool = new Pool(tuple.prefab);
            poolDictionary.Add(tuple.poolableType, pool);
            activeObjects.Add(tuple.poolableType, new Queue<GameObject>());
        }
    }

    // bring this type of object from pool.
    public GameObject GetFromPool(PoolableTypes poolableType)
    {
        if (!poolDictionary.ContainsKey(poolableType))
        {
            Debug.LogError("Dictionary does not contain the given poolableType");
            return null;
        }

        GameObject obj = poolDictionary[poolableType].GetFromPool();
        activeObjects[poolableType].Enqueue(obj);
        return obj;
    }

    // add this type of object into the pool.
    public void AddToPool(GameObject obj, PoolableTypes poolableType)
    {
        if (!poolDictionary.ContainsKey(poolableType))
        {
            Debug.LogError("Dictionary does not contain the given poolableType");
            return;
        }

        activeObjects[poolableType].Dequeue();
        poolDictionary[poolableType].AddToPool(obj);
    }
    
    public List<Queue<GameObject>> GetDesiredActiveObjects()
    {
        List<Queue<GameObject>> activeObjectList = new List<Queue<GameObject>>();
        foreach (KeyValuePair<PoolableTypes, Queue<GameObject>> entry in activeObjects)
        {
            activeObjectList.Add(activeObjects[entry.Key]);
        }
        Debug.Log($"PoolManager - ActiveObjectDictionarySize: {activeObjectList.Count}");
        return activeObjectList;
    }
}
