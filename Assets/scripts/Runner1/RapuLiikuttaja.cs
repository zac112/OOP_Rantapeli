using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapuLiikuttaja : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Liiku");    
    }

    IEnumerator Liiku() {
        while (true) {
            yield return null;
            transform.Translate(Vector3.left * Time.deltaTime);
        }
    }

    void OnBecameInvisible() {
        StopAllCoroutines();
        Destroy(gameObject);
    }
}
