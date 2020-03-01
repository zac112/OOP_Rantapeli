using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveToList : MonoBehaviour
{
    public ObjectList addToList;

    // Start is called before the first frame update
    void Start()
    {
        addToList.GetComponent<ObjectList>().addObject(gameObject); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
