using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tappaja : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag.Equals("Player")) {
            GameState.LoseRun();
            Destroy(GameState.GetMaali());
        }
    }
}
