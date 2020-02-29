using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirstlevel : MonoBehaviour
{
    public int thirst = 5;
    // Update is called once per frame
    void Start()
    {
        IEnumerator coroutine = ThirstGrow();
        StartCoroutine(coroutine);
    }
    private IEnumerator ThirstGrow()
    {
        while (true)
        {
            float waitTime = 4f;

            yield return new WaitForSeconds(waitTime);
            Debug.Log(thirst);
            thirst--;
            if (thirst == 0)
            {
                Object.Destroy(gameObject);
            }
        }
    }
}
