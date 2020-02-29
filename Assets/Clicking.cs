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
        gameObject.SetActive(false);
        Destroy(this);
        Destroy(GetComponent<Dying>());
        SceneManager.LoadScene(scenes[Random.Range(0, scenes.Length)]);
    }

}
