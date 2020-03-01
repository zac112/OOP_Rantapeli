using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lokkiSpawner : MonoBehaviour
{
    public GameObject lokki;

    void Start() {
        
        StartCoroutine(brug());
    }

    IEnumerator brug(){
        while(true){
            yield return new WaitForSeconds(Random.Range(3,5));
            Instantiate(lokki, this.transform);
        }
    }
}
