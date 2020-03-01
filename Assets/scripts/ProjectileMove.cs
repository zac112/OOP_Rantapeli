using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    public float brug;
    GameObject target;

    void Start()
    {
        target = GameObject.FindWithTag("Player");
        shoot();
    }

    void shoot() {
        Vector2 targetPos = new Vector2(target.transform.position.x, target.transform.position.y);
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
        Vector2 direction = targetPos - myPos;
        GetComponent<Rigidbody2D>().velocity = direction * brug;
    }
    void OnCollisionEnter2D(Collision2D pepega)
    {
        Destroy(this.gameObject);
    }
   

}
