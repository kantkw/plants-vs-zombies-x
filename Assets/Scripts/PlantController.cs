using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    Rigidbody2D rb2D;

    // Maximum health of plant
    public int maxHealth = 300;

    // Current health of plant
    int health;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();

        // Set health to maximum health at spawn
        health = maxHealth;
    }

    // Changes health with bounds at 0 and maximum health
    public void ChangeHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
    }
}
