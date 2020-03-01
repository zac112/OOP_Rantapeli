using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField]
    public int runinKesto;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("OdotaVoittoa");
    }

    IEnumerator OdotaVoittoa()
    {
        yield return new WaitForSeconds(runinKesto);
        GameState.WinRun();
    }
}
