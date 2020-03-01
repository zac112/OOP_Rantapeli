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

    private void LoadWinScene() { 
        SceneManager.LoadScene("WinScene");
    }

    public static void LoseRun() {
        singleton.LoadRantaScene();
        print("LOST!");
    }

    public static void WinRun() {
        singleton.LoadRantaScene();
        print("WON!");
        Level levelUp = (Level)FindObjectOfType(typeof(Level));
        levelUp.UpdateXp(25);
    }

    public static void LoseGame()
    {

    }

    public static void WinGame()
    {
        Level levelUp = (Level)FindObjectOfType(typeof(Level));
        int level = levelUp.GetXP();
        if(level == 100){
            singleton.LoadWinScene();
        }
    }
}
