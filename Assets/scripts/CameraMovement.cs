using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public Transform player;

   	void Update()
    {
    	transform.position =new Vector3(player.position.x+3,transform.position.y,transform.position.z);
    }
}
