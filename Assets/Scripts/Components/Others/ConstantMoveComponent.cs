using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMoveComponent : MonoBehaviour
{
    [SerializeField] private float speedMagnitude;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.left * speedMagnitude * Time.deltaTime;
    }

}
