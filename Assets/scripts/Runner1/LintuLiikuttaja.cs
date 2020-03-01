using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LintuLiikuttaja : MonoBehaviour
{
    GameObject player = null;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine("Liiku");   
    }
    IEnumerator Liiku() {
        while (true)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
            yield return null;
        }
    }

    public void AloitaSyoksy() {
        StartCoroutine("Syoksy");
    }
    IEnumerator Syoksy() { 
        while (true) {
            transform.Translate((Vector2.down) * Time.deltaTime*2);
            yield return null;
        }
    }
    void OnBecameInvisible()
    {
        StopAllCoroutines();
        Destroy(gameObject);
    }
}
