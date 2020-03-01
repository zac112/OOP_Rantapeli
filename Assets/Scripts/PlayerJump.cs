using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public bool isGrounded;
    public float jumpHeight = 4;
    Vector3 jump;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "trigger"){
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "trigger"){
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded){  
            rb.AddForce(jump * jumpHeight, ForceMode2D.Impulse);
            //isGrounded = false;
        }
    }
}