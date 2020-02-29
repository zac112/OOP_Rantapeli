using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thirst : MonoBehaviour
{
    [SerializeField]
    public int thirst = 5;
    // Start is called before the first frame update
    void Start()
    {

        // Start function ThirstGrow as a coroutine.

        IEnumerator coroutine = ThirstGrow();
        StartCoroutine(coroutine);
    }

    public void Drink()
    {
        thirst++;
    }
    private IEnumerator ThirstGrow()
    {
        while (true)
        {
            float waitTime = 4f;

            yield return new WaitForSeconds(waitTime);
            thirst--;
            Debug.Log(thirst);
            if (thirst == 0)
            {
                Object.Destroy(gameObject);
            }
        }
    }
}
