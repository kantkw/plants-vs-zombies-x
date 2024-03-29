using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    // Maximum health of plant
    public int maxHealth = 300;

    // Current health of plant.
    private int health;

    private void Awake()
    {
        // Set health to maximum health at spawn
        health = maxHealth;
    }

    // Change health with bounds at 0 and maximum health.
    public void ChangeHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);

        // Remove plant if health depleted.
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
