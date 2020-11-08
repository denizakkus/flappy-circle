using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ResetGameComponent))]
public class GameOverComponent : MonoBehaviour
{
    [SerializeField] UnityEngine.Events.UnityEvent onGameOver;

    private void Awake()
    {
        GameOverUtility.AddOnEndGameListener(() => { onGameOver?.Invoke(); });
    }

}
