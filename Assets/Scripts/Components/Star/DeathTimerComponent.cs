using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTimerComponent : MonoBehaviour
{
    [SerializeField] private float lifeTime = 3;

    PoolableComponent poolableComponent;

    private float timer;

    private void Awake()
    {
        poolableComponent = gameObject.GetComponent<PoolableComponent>();
    }

    private void OnEnable()
    {
        timer = 0;
    }

    private void Update()
    {
        if (timer > lifeTime)
        {
            poolableComponent.AddToPool();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

}
