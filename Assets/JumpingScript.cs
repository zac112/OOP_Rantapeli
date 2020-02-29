using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
{
    public bool isGrounded;
    public float jumpHeight;
    public Vector3 jump;
    Rigidbody2D rb;    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay2D(){
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.Space) && isGrounded)  {
        rb.AddForce(jump * jumpHeight, ForceMode2D.Impulse);
        isGrounded = false;
      }
    }
}