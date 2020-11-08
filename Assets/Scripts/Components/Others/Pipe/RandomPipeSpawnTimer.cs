using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RandomPipeSpawnTimer : MonoBehaviour
{
    [SerializeField] UnityEngine.Events.UnityEvent OnTimeUpEvent;
    [SerializeField] private float maxTime = 3;
    private float timer;

    private void OnEnable()
    {
        timer = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (timer > maxTime)
        {
            OnTimeUpEvent?.Invoke();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
