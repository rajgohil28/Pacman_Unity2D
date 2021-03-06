using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveEnemy : MonoBehaviour
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

        Vector3 displacement = Player.position - transform.position;
        displacement = displacement.normalized;
        transform.position += (displacement * speed * Time.deltaTime);

    }
}