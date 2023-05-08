using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    public float speed = 10;

    void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
        ResetStartingState();
    }

   public void ResetStartingState()
    {
        Rigidbody2D.position=Vector2.zero;
        Rigidbody2D.velocity=Vector2.zero;
        
        var x = Random.Range(0, 1f) < 0.5 ? -1 : 1;
        float y = Random.Range(0, 1f) < 0.5 ? Random.Range(-1, -0.5f) : Random.Range(0.5f, 1);
        Vector2 direction= new Vector2(x,y);
        Rigidbody2D.AddForce(direction*speed);
    }
}
