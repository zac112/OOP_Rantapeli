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
    float move = 5*(prosent/100);
    float x= mask.transform.position.x;
    float y = mask.transform.position.y;
    float z = mask.transform.position.z; 
    mask.transform.position = new UnityEngine.Vector3(x-move,y,z);
}

    /*GameObject-skriptissä täytyy olla Start()-metodi, jossa on vähän sama idea kuin konstruktorissa.
     * Tässä pitäisi ilmeisesti määrittää myös objektin sijainti jollain transform.position-käskyllä? En ole varma
     * ks. Unityn dokumentaatio https://docs.unity3d.com/Manual/CreateDestroyObjects.html
     * https://docs.unity3d.com/Manual/CreatingAndUsingScripts.html
     */
    void Start()
    {
        Instantiate(mask);

    }

void Update()
{
    MoveItem(50);
}

}
