using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawns = null;
    [SerializeField]
    float minWaitTime, maxWaitTime;
    // Start is called before the first frame update
    void Start()
    {
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
        Debug.Log("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        IEnumerator coroutine = WaitAndSpawn();
        StartCoroutine(coroutine);

        Debug.Log("Before WaitAndSpawn Finishes " + Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator WaitAndSpawn()
    {
        BoxCollider2D collider = gameObject.GetComponent<BoxCollider2D>();
        while (true)
        {
            int rndSprite = Random.Range(0, 3);

            float waitTime = Random.Range(minWaitTime, maxWaitTime);

            yield return new WaitForSeconds(waitTime);

            Debug.Log("WaitAndSpawn " + Time.time);
            Instantiate(spawns[rndSprite], 
                new Vector3(Random.Range(collider.bounds.min.x, collider.bounds.max.x),
                Random.Range(collider.bounds.min.y, collider.bounds.max.y), -3), 
                Quaternion.identity);
        }
    }
}
