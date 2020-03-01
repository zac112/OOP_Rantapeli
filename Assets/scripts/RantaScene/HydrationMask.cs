using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


/*
 * Skripti, joka siirtelee keltaisen nesteytyspalkin maskia 
 * - Ajan kuluminen lisää janoisuutta
 *      - tätä varten coroutine
 * - Veden juominen vähentää janoisuutta
 *      - metodi
 * - Kun nesteytyspalkki on nollassa, peli päättyy
 */

public class HydrationMask : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IEnumerator coroutine = HydrationLevel();
        StartCoroutine(coroutine);

    }

    // Update is called once per frame
    void Update()
    {


  
    }

    // ei toimi ainakaan näin
    private IEnumerator HydrationLevel()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            HydrationLevel--;
            GetComponent<HydrationMask>().MoveItem(thirst);
            Debug.Log(thirst);
            if (thirst == 0)
            {
                Object.Destroy(gameObject);
                GameState.LoseGame();
            }
        }

    }

    // Tästä alaspäin sisältö kopioitu skriptistä XPMask.cs, sisältöä kehitetään

    [SerializeField]
    GameObject mask = null;
    [SerializeField]
    Transform taysi = null;
    [SerializeField]
    Transform tyhja = null;

        // Pitäisi ottaa jotenkin syötettä Thirst-skriptiltä
    public void MoveItem(int thirst)
    {
        Debug.Log("saatu " + prosent);
        float etaisyys = Math.Abs(taysi.localPosition.x - tyhja.localPosition.x);
        float move = etaisyys * (prosent / 100f);

        float x = taysi.localPosition.x + move;
        float y = mask.transform.localPosition.y;
        float z = mask.transform.localPosition.z;
        mask.transform.localPosition = new UnityEngine.Vector3(x, y, z);
    }

}
