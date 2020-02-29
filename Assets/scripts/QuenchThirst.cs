using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuenchThirst : MonoBehaviour
{
    GameObject player;
    private Thirst janoScripti;

    private void Start()
    {
        player = GameObject.Find("ukko");
        janoScripti = player.GetComponent<Thirst>();
    }

    void OnMouseDown()
    {
        janoScripti.Drink();
        Object.Destroy(gameObject);
    }
}
