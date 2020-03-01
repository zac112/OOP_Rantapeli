using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelector : MonoBehaviour
{
    [SerializeField]
    GameObject[] points;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator coroutine = Valinta();
        StartCoroutine(coroutine);
    }
    IEnumerator Valinta()
    {
        Debug.Log("Heey");
        while (true)
        {
            if (Input.GetKeyDown("s") || Input.GetKeyDown("down"))
            {
                i = Mathf.Clamp(i+1, 0, points.Length-1);
                Debug.Log(i);
                gameObject.GetComponent<Transform>().position = points[i].GetComponent<Transform>().position;
            }
            if (Input.GetKeyDown("w") || Input.GetKeyDown("up"))
            {
                i = Mathf.Clamp(i - 1, 0, points.Length-1);
                Debug.Log(i);
                gameObject.GetComponent<Transform>().position = points[i].GetComponent<Transform>().position;
            }
            yield return null;
        }
    }
}
