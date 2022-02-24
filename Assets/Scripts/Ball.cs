using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed = 300f;
    private Rigidbody2D ballRb;



    private void Awake()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }
    public void ResetPosition()
    {
        ballRb.position = Vector3.zero;
        ballRb.velocity = Vector3.zero;
       
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

        Vector2 ballDirection = new Vector2(x, y);
        ballRb.AddForce(ballDirection * ballSpeed);


    }

    public void AddForce(Vector2 force)
    {
        ballRb.AddForce(force);
    }

   

}
