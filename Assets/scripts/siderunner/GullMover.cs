using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GullMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Move");
    }

    IEnumerator Move() {
        while (true) {
            Vector3 position = this.transform.position;
            position.x = position.x - 0.05f;
            this.transform.position = position;
            yield return new WaitForSeconds(0.005f);
            //yield return null;
        }
    }



}
