using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VihainenRapu : MonoBehaviour
{

    [SerializeField]GameObject pelaaja = null;
    
    void Start()
    {
        pelaaja = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine("Liiku");
    }

    IEnumerator Liiku() {
        while (true)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
            if(Random.Range(0, 10) < 2)
                if(pelaaja != null && (pelaaja.transform.position - transform.position).y > 0)
                    transform.Translate(Vector3.up * Time.deltaTime);
                else
                    transform.Translate(Vector3.down * Time.deltaTime);
            yield return null;
        }
    }
    void OnBecameInvisible()
    {
        StopAllCoroutines();
        Destroy(gameObject);
    }
}
