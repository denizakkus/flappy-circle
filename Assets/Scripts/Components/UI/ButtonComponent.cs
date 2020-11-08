using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonComponent : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button button;

    private void Awake()
    {
        if (!button)
        {
            Debug.LogError("Button UI of Inspector is empty");
            return;
        }

        Text buttonText = button.GetComponentInChildren<Text>();

        if (buttonText)
        {
            buttonText.text = "RE-PLAY";
        }
    }
}
