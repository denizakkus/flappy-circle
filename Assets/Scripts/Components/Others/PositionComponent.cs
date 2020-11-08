using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionComponent : MonoBehaviour
{
    [SerializeField] private Vector2 position = new Vector2(0, 0);

    private void Start()
    {
        ResetPosition();
    }

    public void ResetPosition()
    {
        transform.position = position;
    }
}
