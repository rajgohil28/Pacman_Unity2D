using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollerEnemy : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "UpCollider")
        {
            transform.Rotate(0, 0, 180);
        }
        if (collision.tag == "DownCollider")
        {
            transform.Rotate(0, 0, 180);
        }
    }
}
