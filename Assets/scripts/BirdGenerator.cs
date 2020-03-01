using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGenerator : MonoBehaviour
{
    public GameObject lintu;
    public GameObject pelaaja;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateBird", 0, Random.Range(3,7));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateBird()
    {
        var uusiLintu = Instantiate(lintu);
        uusiLintu.transform.position = new Vector3(pelaaja.transform.position.x+25, 5+Random.Range(0,1));
    }
}
