using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LintuTunnistin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag.Equals("Player")) {
            transform.parent.gameObject.GetComponent<LintuLiikuttaja>().AloitaSyoksy();
        }
    }
}
