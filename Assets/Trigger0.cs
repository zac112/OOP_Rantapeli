using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger0 : MonoBehaviour
{
    public float aika = 3;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Camera.main.orthographicSize = Mathf.Lerp (11f,5f,c);
            c += 0.01f;
        }
    }
}

