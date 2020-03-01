using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsteGeneraattori : MonoBehaviour
{
    [SerializeField] GameObject[] maaesteet = null;
    [SerializeField] GameObject[] ilmaesteet = null;

    [SerializeField] BoxCollider2D maa = null;
    [SerializeField] BoxCollider2D ilma = null;

    public float maxwait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GeneroiMaa");
        StartCoroutine("GeneroiIlma");
    }

    IEnumerator GeneroiMaa() {
        while (true)
        {
            yield return new WaitForSeconds( Random.Range(2f, maxwait));
            Vector3 position = new Vector3(Random.Range(maa.bounds.min.x, maa.bounds.max.x), Random.Range(maa.bounds.min.y, maa.bounds.max.y),-1f);
            Instantiate(maaesteet[Random.Range(0,maaesteet.Length)],position, Quaternion.identity);

        }
    }

    IEnumerator GeneroiIlma()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2f, maxwait));
            Vector3 position = new Vector3(Random.Range(ilma.bounds.min.x, ilma.bounds.max.x), Random.Range(ilma.bounds.min.y, ilma.bounds.max.y), -1f);
            Instantiate(ilmaesteet[Random.Range(0, ilmaesteet.Length)], position, Quaternion.identity);

        }
    }

}
