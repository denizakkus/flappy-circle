using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUpComponent : MonoBehaviour
{
    [SerializeField] private float maxLifeTime;
    [SerializeField] private bool shouldResetOnEnable;
    [SerializeField] private UnityEngine.Events.UnityEvent onTimeUp;

    private float lifeTime;

    private void OnEnable()
    {
        if (shouldResetOnEnable) lifeTime = 0.0f;
    }

    void Update()
    {
        lifeTime += Time.deltaTime;

        if (lifeTime > maxLifeTime) onTimeUp?.Invoke();
    }
}
