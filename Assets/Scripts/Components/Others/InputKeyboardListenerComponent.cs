using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputKeyboardListenerComponent : MonoBehaviour
{
    [SerializeField] KeyCode jumpCode;
    [SerializeField] UnityEngine.Events.UnityEvent onPress;

    private void Update()
    {
        if (Input.GetKeyDown(jumpCode))
        {
            onPress?.Invoke();
        }
    }
}
