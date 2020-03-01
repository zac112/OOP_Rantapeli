using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    [SerializeField]
    GameObject Death_counter = null;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("GameState");
        if (go == null) {
            go = new GameObject();
            go.name = "GameState";
            go.AddComponent<GameState>();
        }
        GameObject dc = GameObject.Find("Death_counter");
        if (dc == null)
        {
            dc = Instantiate(Death_counter);
            dc.name = "Death_counter";
        }
        else
        {
            DeathCounter dcScript = dc.GetComponent<DeathCounter>();
            dcScript.loadDeath();
        }
    }

}
