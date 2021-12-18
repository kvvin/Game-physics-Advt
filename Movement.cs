using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Vector2 movement;
    public float movementSpeed = 10f;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = new Vector2(Input.acceleration.x, Input.acceleration.y) * movementSpeed;
        rigid.AddForce(movement);
    }
}
