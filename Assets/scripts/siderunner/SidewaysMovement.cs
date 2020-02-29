﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidewaysMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - 0.1f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + 0.1f;
            this.transform.position = position;
        }
    }
}
