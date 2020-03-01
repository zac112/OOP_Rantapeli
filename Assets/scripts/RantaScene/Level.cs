using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int XP;


    public void UpdateXp(int x)
    {
        XP += x;
        
            
        gameObject.GetComponent<XPMask>().MoveItem(x);

        if(XP > 100){
            XP=0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
        UpdateXp(25);

        }
         

    }

}
