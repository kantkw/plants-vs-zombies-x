using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    Rigidbody2D rb2D;
    
    public int maxHealth;
    int health;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();

        health = maxHealth;
    }

    public void ChangeHealth(int amount)
    {
        health = Mathf.Clamp(health + amount, 0, maxHealth);
    }
}
