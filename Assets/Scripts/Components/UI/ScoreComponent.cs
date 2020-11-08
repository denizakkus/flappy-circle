using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreComponent : MonoBehaviour
{
    private static int score = 0;

    private static System.Action<int> scoreIncreaseEvent;
    private static System.Action<int> scoreResetEvent;


    private void OnTriggerExit2D(Collider2D collision)
    {
        Increment();
    }

    private static void Increment()
    {
        score += 1;
        scoreIncreaseEvent?.Invoke(score);
    }

    public void ResetScore()
    {
        score = 0;
        scoreResetEvent?.Invoke(score);
    }

    public static void AddOnScoreIncreaseListener(System.Action<int> listener)
    {
        scoreIncreaseEvent += listener;
    }
    
    public static void AddOnScoreResetListener(System.Action<int> listener)
    {
        scoreResetEvent += listener;
    }
}
