using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int XP=0;


    public void UpdateXp(int x)
    {
        XP += x;
        if(XP > 100){
            XP=0;
        }   
        gameObject.GetComponent<XPMask>().MoveItem(XP);

        
    }

    public int GetXP()
    {
        return XP;
    }



}
