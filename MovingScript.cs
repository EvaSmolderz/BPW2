using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 MoveVelocity;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //Store a reference to the Rigidbody2D component required to use 2D Physics.

    }





    private void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * speed;

    }
}