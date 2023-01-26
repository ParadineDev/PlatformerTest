using UnityEngine;
using System;

[RequireComponent (typeof(Rigidbody2D))]
public class Platformer : MonoBehaviour
{
    [SerializeField][Range(1, 10)] private float _runSpeed = 2f;
    [SerializeField][Range(1, 30)] private float _jumpPower = 8f;
    [SerializeField][Range(1,5)] private int _jumpCountMax = 2;
    private Rigidbody2D _rigidBody;
    private int jumpCount;
    

    public void MoveRight()
    {
        Vector2 velocity = _rigidBody.velocity;
        velocity.x = _runSpeed;
        _rigidBody.velocity = velocity;        
    }

    public void MoveLeft()
    {
        Vector2 velocity = _rigidBody.velocity;
        velocity.x = -_runSpeed;
        _rigidBody.velocity = velocity;   
    }

    public void Jump()
    {
        if (jumpCount < _jumpCountMax)
        {
            jumpCount++;
            Vector2 velocity = _rigidBody.velocity;
            velocity.y = _jumpPower;
            _rigidBody.velocity = velocity;   
        }        
    } 

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        jumpCount = 0;
    }    
}
