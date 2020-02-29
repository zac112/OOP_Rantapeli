using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movelevel : MonoBehaviour
{
    public float speed = 250f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.left*speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
