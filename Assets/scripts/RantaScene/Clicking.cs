using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicking : MonoBehaviour
{
    [SerializeField] int[] scenes;
    private void OnMouseDown()
    {
        GameState.SetMaali(gameObject);
        DontDestroyOnLoad(gameObject);        
        Destroy(this);
        Destroy(GetComponent<Dying>());
        GameObject.FindGameObjectWithTag("Player").GetComponent<CutSceneTimer>().GoSaveVictims();
    }

}
