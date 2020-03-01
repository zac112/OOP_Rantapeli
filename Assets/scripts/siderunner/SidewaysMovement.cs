using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidewaysMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //Vector3 position = this.transform.position;
            //position.x = position.x - 0.1f;
            //this.transform.position = position;

            Vector3 position = new Vector3(-0.1f, 0);
            transform.position += position * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Vector3 position = this.transform.position;
            //position.x = position.x + 0.1f;
            //this.transform.position = position;

            Vector3 position = new Vector3(0.1f, 0);
            transform.position += position * speed;
        }
    }
}
