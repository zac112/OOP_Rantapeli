
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maski : MonoBehaviour
{
[SerializeField]
GameObject mask = null;


public void MoveItem(int prosent)
{
    float move = 5*(prosent/100f);
    float x= mask.transform.position.x;
    float y = mask.transform.position.y;
    float z = mask.transform.position.z; 
    mask.transform.position = new UnityEngine.Vector3(x-move,y,z);
}

    void Start() 
    {
        MoveItem(100);
    }


}
