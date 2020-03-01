using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChungusMovement : MonoBehaviour
{

    public float brug;
    public float jumpForce;
    GameObject target;
    Rigidbody2D rb;
    int counter = 0;
    void Start()
    {
        target = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 targetPos = new Vector2(target.transform.position.x, 0);
        Vector2 myPos = new Vector2(transform.position.x, 0);
        Vector2 direction = targetPos - myPos;
        GetComponent<Rigidbody2D>().velocity = direction * brug;
        if(counter % 180 == 0) jump();
        counter++;
    }

    void jump()
    {   
        //Debug.Log();
        rb.AddForce(new Vector2(0f, jumpForce*1000));
        Debug.Log("Here2");
    }



}
