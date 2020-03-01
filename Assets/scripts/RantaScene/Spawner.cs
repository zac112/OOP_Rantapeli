using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawns = null;
    [SerializeField]
    float maxWaitTime, minWaitTime;
    // Start is called before the first frame update
    void Start()
    {
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"

        // Start function WaitAndPrint as a coroutine.

        IEnumerator coroutine = WaitAndSpawn();
        StartCoroutine(coroutine);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator WaitAndSpawn()
    {
        while (true)
        {
            BoxCollider2D collider = gameObject.GetComponent<BoxCollider2D>();
            int rndSprite = Random.Range(0, 4);
            float waitTime = Random.Range(minWaitTime, maxWaitTime);

            yield return new WaitForSeconds(waitTime);


            Instantiate(spawns[rndSprite], new Vector3(Random.Range(collider.bounds.min.x, collider.bounds.max.x), Random.Range(collider.bounds.min.y, collider.bounds.max.y), -3), Quaternion.identity);
        }
    }
}
