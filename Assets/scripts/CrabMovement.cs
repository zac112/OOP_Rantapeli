using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public LayerMask groundLayer;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, 0f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(!(col.gameObject.layer == 8))
        {
            Debug.Log("toimii");
            speed = (-speed);
        }
    }
}
