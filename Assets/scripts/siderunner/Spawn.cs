using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    public GameObject spawnObject;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Spawning");
    }

    IEnumerator Spawning()
    {
        while (true)
        {
            Instantiate(spawnObject, new Vector3(Random.Range(10.91f, 15f), Random.Range(3.2f, 6f), -2.171875f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
