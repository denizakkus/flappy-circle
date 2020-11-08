using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreViewComponent : MonoBehaviour
{
    private static UnityEngine.UI.Text scoreText;

    private void Awake()
    {
        scoreText = gameObject.GetComponent<UnityEngine.UI.Text>();
    }

    public static void SetScoreText(int score)
    {
        if (!scoreText)
        {
            Debug.Log("scoreText is empty");
            return;
        }
        else
        {
            scoreText.text = $"Score: {score.ToString()}";
        }
    }
} 
