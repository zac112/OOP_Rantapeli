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

    private void LoadMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    private void LoadWinScene() { 
        SceneManager.LoadScene("WinScene");


        Invoke("LoadMainMenu", 15.0f);

    }

    private void LoadLoseScene(){
        SceneManager.LoadScene("LoseScene");
        Invoke("LoadMainMenu", 15.0f);
    }

    public static void LoseRun() {
        singleton.LoadRantaScene();
        print("LOST!");
    }

    public static void WinRun() {
        singleton.LoadRantaScene();
        print("WON!");
        Level levelUp = FindObjectOfType<Level>();
        levelUp.UpdateXp(25);
    }

    public static void LoseGame()
    {

        singleton.LoadLoseScene();
        
    }

    public static void WinGame()
    {
        Level levelUp = FindObjectOfType<Level>();
        int level = levelUp.GetXP();
        if(level == 100){
            singleton.LoadWinScene();
        }
    }
}
