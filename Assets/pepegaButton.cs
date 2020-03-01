using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepegaButton : MonoBehaviour
{
    public GameObject platform;
    public GameObject fireEffect;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy"){
            GameState.WinRun();
            fireEffect.SetActive(true);
            Destroy(platform);

        }
    }


}
