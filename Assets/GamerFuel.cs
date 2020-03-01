using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerFuel : MonoBehaviour
{
    public GameObject gamer;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            gamer.GetComponent<movement1>().jumpForce *= 1.5f;
            Destroy(this.gameObject);
        }

    }
}
