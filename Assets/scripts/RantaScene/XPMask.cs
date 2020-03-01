using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class XPMask : MonoBehaviour
{
    [SerializeField]
    GameObject mask = null;
    [SerializeField]
    Transform taysi = null;
    [SerializeField]
    Transform tyhja = null;

    public Boolean tyhjenee = false;

    

    public void MoveItem(int prosent)
    {

        float etaisyys = Math.Abs(taysi.localPosition.x - tyhja.localPosition.x);
        float move = etaisyys * (prosent/100f);
        float x;

        if(tyhjenee)
        {
            x= tyhja.localPosition.x-move;
        }
        else
        {
            x= taysi.localPosition.x+move;
        }
            float y = mask.transform.localPosition.y;
            float z = mask.transform.localPosition.z; 
            mask.transform.localPosition = new UnityEngine.Vector3(x,y,z);
    }

}
