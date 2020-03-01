using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaatioController : MonoBehaviour
{
    int s;
    Animator anim;
    health h;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        h = gameObject.GetComponent<health>();
        s = h.healthPoints;
    }

    void Update()
    {
        if(h.healthPoints < s)
        {
            s = h.healthPoints;
            anim.Play("TakeDMG");
        }
    }
}
