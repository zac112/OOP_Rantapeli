using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuenchThirst : MonoBehaviour
{

    public Thirst janoScripti;

    private void Start()
    {
        janoScripti = GameObject.FindObjectOfType<Thirst>();
    }

    void OnMouseDown()
    {
        janoScripti.Drink();
        Object.Destroy(gameObject);
    }
}
