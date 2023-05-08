using System;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   public Rigidbody2D Rigidbody2D;
   public float speed=20;

   Vector2 direction;

   private void Update()
    {
        direction=Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Hold W");
            direction = Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Hold S");
            direction = Vector2.down;
        }
    }

   private void FixedUpdate()
   {
       Rigidbody2D.AddForce(direction*speed);
   }
   
}
