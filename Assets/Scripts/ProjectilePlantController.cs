using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePlantController : PlantController
{
    // Interval between each fire of plant
    public float fireInterval;

    // Time until next fire of plant
    float fireTimer;

    // Prefab of projectile that plant fires
    public GameObject projectilePrefab;

    void Update()
    {
        // Tick down the timer and fire when timer reaches 0
        fireTimer -= Time.deltaTime;
        if (fireTimer < 0)
            Fire();
    }

    void Fire()
    {
        // Spawn projectile
        GameObject projectileObject = Instantiate(projectilePrefab, GetComponent<Rigidbody2D>().position + new Vector2(0.5f, 0.2f), Quaternion.identity);

        // Reset time until next fire of plant
        fireTimer = fireInterval;
    }
}
