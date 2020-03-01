using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaaliRunner2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameState.GetMaali().SetActive(true);
        GameState.GetMaali().transform.position = transform.position;
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag.Equals("Player")){
            GameState.WinRun();
            Destroy(GameState.GetMaali());
        }
    }
}
