using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GullMover : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Move");
    }

    IEnumerator Move() {
        while (true) {
            Vector3 position = new Vector3(-0.1f,0);
            transform.position += position * Time.deltaTime * speed;
            yield return null;
        }
    }



}
