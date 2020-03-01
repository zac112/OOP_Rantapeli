using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aaltoscript : MonoBehaviour
{
    public int aaltoiluNopeus;
    Vector3 initialPosition;
    Object[] aallot;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        IEnumerator coroutine = Aaltoile();
        StartCoroutine(coroutine);
        StartCoroutine("FadeOut");
    }
    IEnumerator Aaltoile()
    {
        while (true)
        {

            transform.Translate(Vector3.down*Time.deltaTime);  

            yield return null;
        }
    }

    IEnumerator FadeOut()
    {
        float c = 0f;
        while (true)
        {
            float a = Mathf.Lerp(1f, 0f, c);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, a);
            yield return null;
            c += Time.deltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.transform.position = initialPosition;
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }
}
