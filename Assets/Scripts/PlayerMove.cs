using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    public float faster = 1.2f;
    public float slower = 0.8f;

    private float multiplier = 1;
     public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
           multiplier = faster;
        }
        else if (Input.GetKey(KeyCode.A))
        {
           multiplier = slower;
        }
        else {
            multiplier = 1;
        }
        rb.velocity = new Vector2(speed * Time.deltaTime*multiplier, rb.velocity.y);
        
    }
    
}
