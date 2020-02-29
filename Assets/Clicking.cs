using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicking : MonoBehaviour
{

    private void OnMouseDown()
    {

        SceneManager.LoadScene("SampleScene");
        print("SceneChange");        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
