using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicking : MonoBehaviour
{
    [SerializeField] int[] scenes;
    public static bool clickAllowed = true;
    private void OnMouseDown()
    {
        if (clickAllowed)
        {
            GameState.SetMaali(gameObject);
            DontDestroyOnLoad(gameObject);        
            Destroy(this);
            Destroy(GetComponent<Dying>());
            GameObject.FindGameObjectWithTag("Player").GetComponent<CutSceneTimer>().GoSaveVictims();

        }
    }

}
