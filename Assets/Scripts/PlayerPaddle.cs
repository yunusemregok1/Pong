using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 pDirection;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            pDirection = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            pDirection = Vector2.down;
        }
        else
        {
            pDirection = Vector2.zero;
        }

    }
    private void FixedUpdate()
    {
        if (pDirection.sqrMagnitude != 0)
        {
            PaddleRb.AddForce(pDirection * this.speed);
        }
    }

}
