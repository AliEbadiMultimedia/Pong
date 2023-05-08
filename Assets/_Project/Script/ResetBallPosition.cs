using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBallPosition : MonoBehaviour
{
    public Ball ball;

    private void OnCollisionEnter2D(Collision2D other)
    {
        var ball= other.gameObject.GetComponent<Ball>();
        if (ball!=null)
        {
            ball.ResetStartingState();
        }
      
    }
}
