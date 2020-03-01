using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTrigger : MonoBehaviour
{
    string level;
    void Start()
    {
        level = SceneManager.GetActiveScene().name;
        Collider2D player = GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D player){
        if (player.tag == "Player"){
           SceneManager.LoadScene(level);
         }
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
