using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(Random.Range(-3f, 0), 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.tag.Equals("Pile"))
        {
            Object.Destroy(gameObject);
        }
    }
}
