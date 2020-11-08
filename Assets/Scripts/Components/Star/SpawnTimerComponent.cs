using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnTimerComponent : MonoBehaviour
{
    [SerializeField] private List<UnityEngine.Events.UnityEvent> onTimeUp;
    [SerializeField] private List<float> waitingTimes;

    private List<float> times;

    private void Awake()
    {
        times = new List<float>();
    }

    private void OnEnable()
    {
        MatchTimes();
    }

    private void Update()
    {
        TimeUpHandler();
    }

    private void TimeUpHandler()
    {
        for (int i = 0; i < times.Count; i++)
        {
            if (times[i] > waitingTimes[i])
            {
                times[i] = 0;
                onTimeUp[i]?.Invoke();
            }
            times[i] += Time.deltaTime;
        }
    }

    private void MatchTimes()
    {
        times.Clear();
        if (waitingTimes.Count > 0)
        {
            for (int i = 0; i < waitingTimes.Count; i++)
            {
                times.Add(waitingTimes[i]);
            }
        }
    }
}
