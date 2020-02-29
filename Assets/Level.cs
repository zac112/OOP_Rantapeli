using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int XP;
    public int currentLevel;


    public void UpdateXp(int x)
    {
        XP += x;

        int curlevel = (int) (0.1f * Math.Sqrt(XP));
        
            
        if(curlevel != currentLevel){
            currentLevel = curlevel;
            //You reached a new level!
        }

        int xpnextlevel = 100 * (currentLevel +1) * (currentLevel +1);
        int differencexp = xpnextlevel - XP;

        int totaldifference = xpnextlevel - (100 * currentLevel * currentLevel);
    }

    // Update is called once per frame
    void Update()
    {
         
        UpdateXp(5);

    }

}
