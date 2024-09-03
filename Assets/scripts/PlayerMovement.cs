using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public bool isJumping;
    public float JumpForce;
    Rigidbody2D rbPlayer;
    [SerializeField] float speed = 5f;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }
   
    private void FixedUpdate()
    {
        Move();
        Jump();
        
    }

    void Move()
    {
        float xMove = Input.GetAxis("Horizontal");
        rbPlayer.velocity = new Vector2(xMove * speed, rbPlayer.velocity.y);

        if (xMove > 0)
        {
            transform.eulerAngles = new Vector2(0,0);
        }
        else if (xMove < 0)
        {
            transform.eulerAngles = new Vector2(0,180);
        }
    }

    void Jump()
   {
    if(Input.GetButtonDown("Jump") && !isJumping)
    {
        rbPlayer.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
    }
   }
    }

