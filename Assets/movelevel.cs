using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movelevel : MonoBehaviour
{
    public float speed = 250f;
    public Rigidbody2D rb;
    public double c1;
    public double c2;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.right*speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(counter<5){
            counter++;
        }
        else{
        c1=transform.position.x;
        if(c1==c2){
            rb.AddForce(Vector3.right*speed);
        }
        c2=transform.position.x;
        }
    }
    
}
