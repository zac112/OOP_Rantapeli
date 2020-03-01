using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rapu : MonoBehaviour
{
 public float MoveSpeed = 3f;





    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("move");
    }

    IEnumerator move()
    {
        while(true){
        yield return FlyStraight();
        }
    }

    IEnumerator FlyStraight()
    {

        while (true)
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
            yield return null;
        }
    }
}

