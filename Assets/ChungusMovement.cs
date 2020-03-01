using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChungusMovement : MonoBehaviour
{

    public float brug;
    public float jumpForce;
    GameObject target;
    Rigidbody2D rb;

    void Start()
    {
        target = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        jump();
    }

    void FixedUpdate()
    {
        Vector2 targetPos = new Vector2(target.transform.position.x, 0);
        Vector2 myPos = new Vector2(transform.position.x, 0);
        Vector2 direction = targetPos - myPos;
        GetComponent<Rigidbody2D>().velocity = direction * brug;
    }

    IEnumerator jump()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(8,12));
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }



}
