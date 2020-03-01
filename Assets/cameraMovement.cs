using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        if(player.position.x+2 > transform.position.x)
            transform.position = new Vector3(player.position.x+2, transform.position.y, transform.position.z);        
    }
}
