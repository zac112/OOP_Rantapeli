using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thirst : MonoBehaviour
{
    
    [SerializeField] public int thirst = 90;
    [SerializeField] float waitTime = 1f;
    // Start is called before the first frame update
    void Start()
    {

        // Start function ThirstGrow as a coroutine.

        IEnumerator coroutine = ThirstGrow();
        StartCoroutine(coroutine);
    }

    public void Drink()
    {
        thirst += 10;
        GetComponent<XPMask>().MoveItem(thirst);
    }

    

    private IEnumerator ThirstGrow()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            thirst--;
            GetComponent<XPMask>().MoveItem(thirst);
            Debug.Log(thirst);
            if (thirst == 0)
            {
                Object.Destroy(gameObject);
                GameState.LoseGame();
            }
        }
    }
}
