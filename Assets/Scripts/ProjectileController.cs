using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    Rigidbody2D rb2D;

    public int damage;
    public Vector2 force;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
            Destroy(gameObject);
    }

    public void Fire()
    {
        rb2D.AddForce(force);
    }
}
