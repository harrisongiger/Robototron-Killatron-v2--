using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody rb;
    Vector3 myInput;
    Vector3 moveVelocity;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        myInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = myInput * moveSpeed;
    }

    void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }
}
