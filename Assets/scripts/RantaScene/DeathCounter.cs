using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    int deathCount = 0;
    [SerializeField]
    GameObject lifeLeft = null;
    [SerializeField]
    GameObject lifeGone = null;
    [SerializeField]
    int deathLimit;
    GameObject[] lifeArray;
    float xCor;
    float yCor;
    float zCor;
    // Start is called before the first frame update
    void Start()
    {
        lifeArray = new GameObject[deathLimit];
        for (int i = 0; i < deathLimit; i++)
        {
            lifeArray[i] = Instantiate(lifeLeft, new Vector3(-6f+i, 4.5f, -1f), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (deathCount >= deathLimit)
        {
            GameState.LoseGame();
        }
    }

    public void DeathChange()
    {
        deathCount++;
        xCor = lifeArray[deathCount - 1].transform.position.x;
        yCor = lifeArray[deathCount - 1].transform.position.y;
        zCor = lifeArray[deathCount - 1].transform.position.z;
        Destroy(lifeArray[deathCount - 1]);
        lifeArray[deathCount - 1] = Instantiate(lifeGone, new Vector3(xCor, yCor, zCor), Quaternion.identity);
    }
}
