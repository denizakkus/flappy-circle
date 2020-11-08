using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScoreViewDependencyInjectorComponent : MonoBehaviour
{
    
    private void Awake()
    {
        ScoreComponent.AddOnScoreIncreaseListener((int score) => { ScoreViewComponent.SetScoreText(score); });
        ScoreComponent.AddOnScoreResetListener((int score) => { ScoreViewComponent.SetScoreText(score);  });
    }
}
