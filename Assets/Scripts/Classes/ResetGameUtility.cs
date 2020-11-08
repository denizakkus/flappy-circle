using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResetGameUtility
{
    private static System.Action onResetGame;


    public static void ResetGame()
    {
        onResetGame?.Invoke();
    }

    public static void AddOnResetGameListener (System.Action listener)
    {
        onResetGame += listener;
    }
}
