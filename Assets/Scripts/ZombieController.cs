using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Maximum health of zombie.
    public int maxHealth = 270;

    // Current health of zombie.
    private int health;

    // Speed of zombie.
    public float speed = 0.2f;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();

        // Set health to maximum health at spawn.
        health = maxHealth;
    }

    private void FixedUpdate()
    {
        // Continuously change position of zombie.
        Vector2 position = rb2d.position;
        position = position + new Vector2(-1, 0) * speed * Time.deltaTime;
        rb2d.MovePosition(position);
    }

    // Change health with bounds at 0 and maximum health.
    public void ChangeHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);

        // Remove zombie if health depleted.
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
