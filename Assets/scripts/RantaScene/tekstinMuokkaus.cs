using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tekstinMuokkaus : MonoBehaviour
{
    public UnityEngine.UI.Text someText;

    void Start()
    {
        someText = GetComponent<UnityEngine.UI.Text>();
    }

    void Update()
    {
        ChangeNumber(5);
    }

    void ChangeNumber(int b)
    {
        someText.text = "Level: " + b.ToString();
    }
}
