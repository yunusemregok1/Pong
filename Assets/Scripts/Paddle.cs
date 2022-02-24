using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10f;
    
    protected Rigidbody2D PaddleRb;


    private void Awake()
    {
        PaddleRb = GetComponent<Rigidbody2D>();
    }

    public void ResetPositionPaddle()
    {
        PaddleRb.position = new Vector2(PaddleRb.position.x, 0.0f);
        PaddleRb.velocity = Vector2.zero;
    }
}
