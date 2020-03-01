using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour
{
    [SerializeField]
    private float minLifeTime, maxLifeTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitAndDie");
    }

    private IEnumerator WaitAndDie()
    {
        yield return new WaitForSeconds(Random.Range(minLifeTime, maxLifeTime));
        Object.Destroy(gameObject);
    }
}
