using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChungusMovement : MonoBehaviour
{

    public float brug;
    public float jumpForce;
    public int br;
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
        rb.velocity += direction * brug;

        if(counter % br == 0) jump();
        counter++;   

        Vector3 temp = transform.rotation.eulerAngles;
        if(target.transform.position.x > transform.position.x){
            temp.y = 0;
            transform.rotation = Quaternion.Euler(temp);
        }
        else{
            temp.y = 180;
            transform.rotation = Quaternion.Euler(temp);
        }
    }

    void jump()
    {   
        rb.AddForce(new Vector2(0f, jumpForce));
    }



}
