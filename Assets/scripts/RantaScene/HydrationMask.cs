using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


/*
 * Skripti, joka siirtelee keltaisen nesteytyspalkin maskia eli nesteytyspalkin täyttöastetta
 * janoisuuden (syötettä Thirst-skriptiltä) mukaan.
 */

public class HydrationMask : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        // Tästä alaspäin sisältö kopioitu skriptistä XPMask.cs, sisältöä kehitetään
    }

    [SerializeField]
    GameObject mask = null;
    [SerializeField]
    Transform taysi = null;
    [SerializeField]
    Transform tyhja = null;

        // Pitäisi ottaa jotenkin syötettä Thirst-skriptiltä
    public void MoveItem(int prosent)
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
