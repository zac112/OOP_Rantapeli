using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawns = null;
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

        Debug.Log("Before WaitAndPrint Finishes " + Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator WaitAndSpawn()
    {
        while (true)
        {
            int rndSprite = Random.Range(0, 3);
            float waitTime = Random.Range(1f, 2f);

            yield return new WaitForSeconds(waitTime);

            Debug.Log("WaitAndPrint " + Time.time);
            Instantiate(spawns[rndSprite], new Vector3(Random.Range(-7f, 7f), Random.Range(-1.5f, 2f), 0), Quaternion.identity);
        }
    }
}
