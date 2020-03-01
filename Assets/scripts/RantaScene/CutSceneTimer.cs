using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneTimer : MonoBehaviour
{
    [SerializeField] Sprite binocs = null;
    [SerializeField] GameObject[] waypoints = null;
    [SerializeField] int[] scenes;
    [SerializeField] GameObject siirtymaPic = null;

    private float timer = 0f;
    private float timerLimit = 3f;
    private bool running = false;
    // Start is called before the first frame update
    public void GoSaveVictims()
    {
        if (!running)
        {
            running = true;
            Clicking.clickAllowed = false;
            StartCoroutine("CutScene");
        }
    }

    IEnumerator CutScene() {
        yield return Binocs();
        yield return RunSave();
        running = false;
        Clicking.clickAllowed = true;
        LoadRunningScene();
    }

    private IEnumerator Binocs() {
        GetComponent<SpriteRenderer>().sprite = binocs;
        siirtymaPic.SetActive(true);
        yield return new WaitForSeconds(3f);
        siirtymaPic.SetActive(false);
    }

    private IEnumerator RunSave()
    {
        foreach (GameObject go in waypoints)
        {
            float targetTime = Time.time + 2f;
            float startTime = Time.time;
            Vector3 startPos = transform.position;
            
            GetComponent<SpriteRenderer>().sprite = go.GetComponent<Waypoint>().lifeguardSprite;
            if (go.GetComponent<Waypoint>().runningAnimation != null)
            {
                GetComponent<Animator>().runtimeAnimatorController = go.GetComponent<Waypoint>().runningAnimation;
                GetComponent<Animator>().Play("Lifeguard_run_left");
            }

            while (Time.time < targetTime)
            {
                transform.position = Vector3.Lerp(startPos, go.transform.position, (Time.time - startTime) / (targetTime-startTime));
                yield return null;
            }
        }
    }

    private void LoadRunningScene() {
        GameState.GetMaali().SetActive(false);
        SceneManager.LoadScene(scenes[Random.Range(0, scenes.Length)]);
    }
}
