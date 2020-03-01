using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    int hp = 3;
    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
    // Start is called before the first frame update
    void Start()
    {

    }


     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (hp == 3)
            {
                h3.transform.gameObject.SetActive(false);
                hp--;
                Destroy(collision.gameObject);
            }
            else if (hp == 2)
            {
                h2.transform.gameObject.SetActive(false);
                hp--;
                Destroy(collision.gameObject);
            }
            else if (hp == 1)
            {
                h1.transform.gameObject.SetActive(false);
                hp--;
                Destroy(collision.gameObject);
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
