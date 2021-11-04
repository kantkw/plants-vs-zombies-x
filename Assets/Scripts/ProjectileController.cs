using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    Rigidbody2D rb2D;

    // Damage per shot of projectile
    public int damage;

    // Initial force applied to projectile
    public Vector2 force;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();

        // Apply initial force to projectile
        rb2D.AddForce(force);
    }
}
