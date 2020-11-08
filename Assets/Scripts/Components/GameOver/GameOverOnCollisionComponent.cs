using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverOnCollisionComponent : MonoBehaviour
{
    // If you want to add different action
    // when gameobject dead, go for it.
    private static System.Action deathEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameOverUtility.EndGame();
    }

    public static void AddOnGameOverListener(System.Action listener)
    {
        deathEvent += listener;
    }
    
}
