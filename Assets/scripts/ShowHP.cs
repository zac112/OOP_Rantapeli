using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHP : MonoBehaviour
{

    public int HP;

    void Update()
    {
        if (HP == 3)
        {
            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("3HP");
        }
        else if(HP == 2)
        {
            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("2HP");
        }
        else if (HP == 1)
        {
            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("1HP");
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("0HP");
        }
    }
}
