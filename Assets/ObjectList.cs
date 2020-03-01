using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectList : MonoBehaviour
{
    ArrayList gameobjects = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            foreach (GameObject go in gameobjects)
            {
                print(go);
            }
        }
    }

    public void addObject(GameObject gameobject)
    {
        gameobjects.Add(gameobject);
    }
}
