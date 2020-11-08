using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameOverUtility
{

    private static System.Action onEndGame;

    public static void EndGame()
    {
        onEndGame?.Invoke();
    }

    public static void AddOnEndGameListener (System.Action listener)
    {
        onEndGame += listener;
    }

}
