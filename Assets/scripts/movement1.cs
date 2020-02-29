using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public LayerMask ground;
    private Rigidbody2D rb;
    public bool isGrounded;
    public Transform groundCheck;


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
        
        else if(Input.GetKey(KeyCode.LeftArrow))
            rb.velocity = new Vector2(-speed, transform.InverseTransformDirection(rb.velocity).y);

        else
            rb.velocity = new Vector2(0f, transform.InverseTransformDirection(rb.velocity).y);

    }

    void Update()
    {
        isGrounded = Physics2D.OverlapArea(groundCheck.position, groundCheck.position, ground);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
