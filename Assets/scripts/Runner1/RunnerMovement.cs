using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Liiku");
    }

    IEnumerator Liiku() {
        while (true) {
            if (Input.GetKey("up")) {
                transform.Translate(Vector2.up * Time.deltaTime);
            }
            if (Input.GetKey("down"))
            {
                transform.Translate(-Vector2.up * Time.deltaTime);
            }
            if (Input.GetKey("right"))
            {
                transform.Translate(Vector2.right * Time.deltaTime);
            }
            if (Input.GetKey("left"))
            {
                transform.Translate(Vector2.left * Time.deltaTime);
            }
            yield return null;
        }
    }
}
