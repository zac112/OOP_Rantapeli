using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movelevel : MonoBehaviour
{
    public float speed = 250f;
    public Rigidbody2D rb;
    public double c1;
    public double c2;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.right*speed);
    }

    // Update is called once per frame
    void Update()
    {
        if()
            speed=250f;
            rb.AddForce(Vector3.right*speed);
    }
}
