using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrigger : MonoBehaviour
{
    void Start()
    {
        Collider2D player = GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D player){
        if (player.tag == "Player"){
            player.transform.localPosition = new Vector3(-9.949f, -1.691f, 0.0f);
            Debug.Log("asd");
         }
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
