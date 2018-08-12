using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPWAsset : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 MoveVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        MoveVelocity = moveInput.normalized * speed;

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + MoveVelocity * Time.fixedDeltaTime);
    }
}