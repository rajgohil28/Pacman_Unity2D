using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyEnemyAi : MonoBehaviour
{
    public Transform[] waypoints;
    int cur = 0;
    public bool activated;

    public float speed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {

    }
    void FixedUpdate()
    {
        if (activated)
            // Waypoint not reached yet? then move closer
            if (transform.position != waypoints[cur].position)
            {
                Vector2 p = Vector2.MoveTowards(transform.position,
                                                waypoints[cur].position,
                                                speed);
                GetComponent<Rigidbody2D>().MovePosition(p);
            }
            // Waypoint reached, select next one
            else
            { cur = (cur + 1) % waypoints.Length; }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            activated = true;
        }
    }
}