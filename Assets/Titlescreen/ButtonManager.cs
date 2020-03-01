using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update

   public void play(){
    SceneManager.LoadScene("Rantascene", LoadSceneMode.Additive);
   }
   public void exit()
    {
      Application.Quit();
      Debug.Log("Exited!");
    }

    // Update is called once per frame
}
