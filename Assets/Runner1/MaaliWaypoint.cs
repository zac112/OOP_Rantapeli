using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaaliWaypoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameState.GetMaali().AddComponent<RapuLiikuttaja>();
        GameState.GetMaali().AddComponent<Maali>();
        GameState.GetMaali().transform.position = transform.position;

    }
}
