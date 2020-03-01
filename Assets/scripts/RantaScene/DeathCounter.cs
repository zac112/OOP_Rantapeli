using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCounter : MonoBehaviour
{
    int deathCount = 0;
    [SerializeField]
    public GameObject lifeLeft = null;
    [SerializeField]
    GameObject lifeGone = null;
    [SerializeField]
    public int deathLimit;
    public GameObject[] lifeArray;
    float xCor;
    float yCor;
    float zCor;
    bool[] states;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        lifeArray = new GameObject[deathLimit];
        states = new bool[deathLimit];
        for (int i = 0; i < deathLimit; i++)
        {
            lifeArray[i] = Instantiate(lifeLeft, new Vector3(-6f+i, 4.5f, -1f), Quaternion.identity);
            states[i] = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (deathCount >= deathLimit)
        {
            GameState.LoseGame();
        }

        //if (SceneManager.GetSceneByName("Rantascene").isLoaded)
        //{
        //    print("loadDeath()");
        //}
    }

    public void DeathChange()
    {
        deathCount++;
        xCor = lifeArray[deathCount - 1].transform.position.x;
        yCor = lifeArray[deathCount - 1].transform.position.y;
        zCor = lifeArray[deathCount - 1].transform.position.z;
        Destroy(lifeArray[deathCount - 1]);
        lifeArray[deathCount - 1] = Instantiate(lifeGone, new Vector3(xCor, yCor, zCor), Quaternion.identity);
        states[deathCount - 1] = false;
    }

    public void loadDeath()
    {
        for (int i = 0; i<deathLimit; i++)
        {
            if (states[i])
            {
                lifeArray[i] = Instantiate(lifeLeft, new Vector3(-6f + i, 4.5f, -1f), Quaternion.identity);
            }
            else
            {
                lifeArray[i] = Instantiate(lifeGone, new Vector3(-6f + i, 4.5f, -1f), Quaternion.identity);
            }
        }
    }
}
