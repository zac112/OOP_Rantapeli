using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireEffect : MonoBehaviour
{
    public float gaming;
    
    private void Update() {
        transform.localScale = new Vector3(transform.localScale.x + gaming, transform.localScale.y + gaming, transform.localScale.z);
    }
}
