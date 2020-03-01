using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scenes : MonoBehaviour
{

    public void restartScene(){
        SceneManager.LoadScene("BigChungus");
        Time.timeScale = 1;
    }
}
