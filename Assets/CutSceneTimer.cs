using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneTimer : MonoBehaviour
{

    private float timer = 0f;
    private float timerLimit = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("wait");
    }

    IEnumerator wait() {

        yield return new WaitForSeconds(timerLimit);

        SceneManager.LoadScene("Rantascene");

    }
}
