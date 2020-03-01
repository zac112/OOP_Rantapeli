using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    int hp = 3;

    string level;
    public GameObject h1;
    public GameObject h2;
    public GameObject h3;

    // Start is called before the first frame update
    void Start()
    {
        level = SceneManager.GetActiveScene().name;
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
                SceneManager.LoadScene(level);
            }
            if(hp==0){
                GameState.LoseRun();
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
