using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

//[ExecuteInEditMode]
public class CrabJump : MonoBehaviour
{

    public Vector2 jump;

    public LayerMask groundLayer;

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 0.5f;

        //Debug.DrawRay(position, direction * distance, Color.green);

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector2(-3.0f, 8.0f);
    }


    void Update()
    {
        if (IsGrounded())
        {
            float yMovement = rb.velocity.y;
            if (yMovement == 0)
            {
                //rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
                rb.velocity = jump;
            }
        }
    }
}

