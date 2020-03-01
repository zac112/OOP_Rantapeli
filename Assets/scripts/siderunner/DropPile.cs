using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPile : MonoBehaviour
{
    [SerializeField]
    private GameObject pile;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Drop");
    }

    IEnumerator Drop()
    {
        while (true) 
        {
            Vector3 position = this.transform.position;
            position.y = position.y - 1f;
            Instantiate(pile, position, new Quaternion(0, 0, 0, 0));
            yield return new WaitForSeconds(Random.Range(0.5f, 2f));
        }
    }
}
