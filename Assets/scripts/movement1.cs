using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rb;
    public LayerMask groundLayer;
    public Camera cam;
    Vector3 screenPos;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.RightArrow))
            rb.velocity = new Vector2(speed, transform.InverseTransformDirection(rb.velocity).y);
        
        else if(Input.GetKey(KeyCode.LeftArrow) && !isBackWall())
            rb.velocity = new Vector2(-speed, transform.InverseTransformDirection(rb.velocity).y);

        else
            rb.velocity = new Vector2(0f, transform.InverseTransformDirection(rb.velocity).y);

    }

    void Update()
    {
        screenPos = cam.WorldToScreenPoint(transform.position);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    bool IsGrounded()
    {
        Vector2 position = this.transform.position;
        Vector2 direction = Vector2.down;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, 1.1f, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

    bool isBackWall()
    { 

        if (screenPos.x < 20)
            return true;

        return false;
    }
}
