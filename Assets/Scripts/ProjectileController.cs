using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private Rigidbody2D rb2D;

    // Damage per shot of projectile.
    public int damage = 20;

    // Initial force applied to projectile.
    public Vector2 force = new Vector2(75, 0);

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();

        // Apply initial force to projectile.
        rb2D.AddForce(force);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ZombieController zombie = other.GetComponent<ZombieController>();

        if (zombie != null)
        {
            // Change health of zombie.
            zombie.ChangeHealth(damage * -1);

            // Remove projectile.
            Destroy(gameObject);
        }
    }
}
