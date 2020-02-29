using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    private static GameState singleton;

    public GameObject maali = null;

    void Awake() {
        maali = new GameObject();
        singleton = this;
        DontDestroyOnLoad(gameObject); 
        
    }


    public static void SetMaali(GameObject maali)
    {
        singleton.maali = maali;
    }

    public static GameObject GetMaali() {
        return singleton.maali;
    }
    private void LoadRantaScene() { 
        SceneManager.LoadScene("Rantascene");
    }

    public static void LoseRun() {
        singleton.LoadRantaScene();
        print("LOST!");
    }

    public static void WinRun() {
        singleton.LoadRantaScene();
        print("WON!");
    }

    public static void LoseGame()
    {

    }

    public static void WinGame()
    {

    }
}
