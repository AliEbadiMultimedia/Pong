using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : MonoBehaviour
{
    public Rigidbody2D paddle;
    public Rigidbody2D ball;

    private Vector2 direction;
    public float Speed=10;

    private void Update()
    {
        direction=Vector2.zero;
        if (ball.velocity.x>0)
        {
            if (ball.position.y>paddle.position.y)
            {
                direction=Vector2.up;
            }
            else
            {
                direction=Vector2.down;
            }
        }
        else
        {
            if (paddle.position.y<0)
            {
                direction=Vector2.up;
            }
            else
            {
                direction=Vector2.down;
            }
        }
   
    }

    private void FixedUpdate()
    {
        paddle.AddForce(direction*Speed);
    }
}
