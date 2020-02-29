using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    private static GameState singleton;

    public GameObject maali = null;

    void Awake() {
        Init();
    }

    private static void Init() {
        if (singleton == null)
        {
            GameObject go = new GameObject();
            singleton = go.AddComponent<GameState>();
            singleton.maali = new GameObject();
            DontDestroyOnLoad(go);
        }
    }

    public static void SetMaali(GameObject maali)
    {
        Init();
        singleton.maali = maali;
    }

    public static GameObject GetMaali() {
        Init();
        return singleton.maali;
    }
    private void LoadRantaScene() { 
        SceneManager.LoadScene("Rantascene");
    }

    public static void LoseRun() {
        Init();
        singleton.LoadRantaScene();
    }

    public static void WinRun() {
        Init();
        singleton.LoadRantaScene();
    }
}
