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
            Instantiate(spawnObject, new Vector3(15f, Random.Range(4f, 6.2f), -2.171875f), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        }
    }
}
