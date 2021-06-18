using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyEnemyScript : MonoBehaviour
{
    public float speed = 0.5f;
    public Transform Player;
    public bool activated;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activated) { 
        Vector3 displacement = Player.position - transform.position;
        displacement = displacement.normalized;
        transform.position += (displacement * speed * Time.deltaTime);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        { activated = true; }
        

    }

}
