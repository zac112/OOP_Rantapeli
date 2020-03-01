using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public float aika = 1.5f;
    public float loppu = 10;
    // Start is called before the first frame update
    void Start()
    {
    Collider2D C = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D C){
        StartCoroutine("zoom1");
    }
    IEnumerator zoom1() {
    Debug.Log("toimii?");
        float t = Time.time;
        float c = 0;
        while(Time.time<t+aika){
            yield return null;
            Camera.main.orthographicSize = Mathf.Lerp (Camera.main.orthographicSize,loppu,c);
            c = (t+aika-Time.time)/(t+aika);
        }
    }
}
    
 