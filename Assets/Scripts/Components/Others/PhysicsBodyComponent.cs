using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsBodyComponent : MonoBehaviour
{
    [SerializeField] private float gravityScale = 10;

    Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    public void OnResetGame()
    {
        DisableGravity();
        ResetVelocity();
    }

    public void EnableGravity()
    {
        rigidbody2D.gravityScale = gravityScale;
    }

    public void DisableGravity()
    {
        rigidbody2D.gravityScale = 0;
    }

    public void ResetVelocity ()
    {
        rigidbody2D.velocity = Vector2.zero;
    }
}
