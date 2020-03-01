using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("GameState");
        if (go == null) {
            go = new GameObject();
            go.name = "GameState";
            go.AddComponent<GameState>();
        }
    }

}
