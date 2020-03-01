using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lokkiSpawner : MonoBehaviour
{
    public GameObject lokki;
    public float minProjectileDelay;
    public float maxProjectileDelay;
    void Start() {
        
        StartCoroutine(brug());
    }

    IEnumerator brug(){
        while(true){
            yield return new WaitForSeconds(Random.Range(minProjectileDelay,maxProjectileDelay));
            Instantiate(lokki, this.transform);
        }
    }
}
