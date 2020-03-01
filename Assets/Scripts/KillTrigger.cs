using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTrigger : MonoBehaviour
{
    
    void Start()
    {
        Collider2D player = GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D player){
        if (player.tag == "Player"){
           GameState.LoseRun();
         }
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
