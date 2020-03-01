using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehavior : MonoBehaviour
{
    public GameObject pelaaja;
    public GameObject uloste;
    bool pudotettu = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPosition = transform.position; // We store the current position
        newPosition.x -= 0.1f;
        transform.position = newPosition;

        if (transform.position.x < pelaaja.transform.position.x + 2f && !pudotettu)
        {
            pudotettu = true;
            var uusiUloste = Instantiate(uloste);
            uusiUloste.transform.position = gameObject.transform.position;
        }

        if (transform.position.x < pelaaja.transform.position.x - 5f && transform.position.x > pelaaja.transform.position.x - 100f)
            Destroy(gameObject);
    }
}
