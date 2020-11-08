using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameOverComponent))]
public class ResetGameComponent : MonoBehaviour
{
    [SerializeField] UnityEngine.Events.UnityEvent onResetGame;

    private void Awake()
    {
        ResetGameUtility.AddOnResetGameListener( ()=> { onResetGame?.Invoke(); });
    }
}
