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
        if (Random.value < 0.5f)
        {
            GameState.GetMaali().SetActive(true);
            GameState.GetMaali().transform.position = waypoint.transform.position;
        }
    }
}
