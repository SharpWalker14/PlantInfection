using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2d;
    private float timer;
    void Start()
    {
        timer = 1.5f;
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        AnimalGoing();
    }

    void AnimalGoing()
    {
        timer += Time.deltaTime;

        Vector3 vel = rb2d.velocity;
        vel.x = speed;
        rb2d.velocity = vel;

        if (timer >= 3)
        {
            speed *= -1;
            timer = 0;
        }
    }
}
