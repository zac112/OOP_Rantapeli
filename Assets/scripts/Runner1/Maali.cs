using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maali : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            Destroy(gameObject);
            GameState.WinRun();
        }
        else if (!col.tag.Equals("Tausta"))
        {
            Destroy(col.gameObject);
        }
    }
}
