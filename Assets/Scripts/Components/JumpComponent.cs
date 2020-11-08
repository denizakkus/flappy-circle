using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JumpComponent : MonoBehaviour
{
    [SerializeField] float jumpVelocityMagnitude;

    private Rigidbody2D objectRigidbody;

    private void Awake()
    {
        this.objectRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    public void jump()
    {
        this.objectRigidbody.velocity = this.transform.up * jumpVelocityMagnitude;
    }
}
