using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liike : MonoBehaviour
{
    public float flySpeed = 3f;
    public float startDelay = 1f;
    public float bottomTime = 1f;
    public int bottomPosition = 0;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Fly");
    }

    IEnumerator Fly()
    {
        while(true){
        yield return FlyStraight(startDelay);
        yield return FlyDown();
        yield return FlyStraight(bottomTime);
        yield return FlyUp();
        }
    }
    
    IEnumerator FlyStraight(float flyTime)
    {
        timer = Time.time;
        while (Time.time <= timer + flyTime) {
            transform.Translate(Vector3.left * Time.deltaTime * flySpeed);
            yield return null;
        }
    }

    IEnumerator FlyDown()
    {
        while (transform.position.y >= bottomPosition)
        {
            transform.Translate(new Vector3(-1, -1, 0) * Time.deltaTime * flySpeed);
            yield return null;
        }
    }
    IEnumerator FlyUp()
    {
        while (transform.position.y <= 6)
        {

            transform.Translate(new Vector3(-1, 1, 0) * Time.deltaTime * flySpeed);
            yield return null;
        }
    }
}
