using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartAnimation : MonoBehaviour
{
    float a = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        a -= 0.001f;

        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,a);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.005f, gameObject.transform.position.z);
    }
}
