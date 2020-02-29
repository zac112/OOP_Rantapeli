using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    public float maara = 0;
    public GameObject waypoint = null;

    void Start()
    {
        StartCoroutine("Move");
    }

    IEnumerator Move() {
        while (true) {
            yield return null;
            transform.Translate(Vector2.left * Time.deltaTime);
        }
    }

    void OnBecameInvisible() {
        transform.position = new Vector3(transform.position.x+maara, transform.position.y, transform.position.z);
        if (GameState.GetMaali() != null && Random.value < 0.8f)
        {
            GameState.GetMaali().SetActive(true);
        }
    }
}
