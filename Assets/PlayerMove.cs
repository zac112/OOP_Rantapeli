using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    public float faster = 1.2f;
    public float slower = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            transform.position += Vector3.right * (speed * faster) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * (speed * slower) * Time.deltaTime;
        }
        else {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        
    }
    
}
