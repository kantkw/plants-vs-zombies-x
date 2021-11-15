using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePlantController : PlantController
{
    // Interval between each fire of plant.
    public float fireInterval = 1.5f;

    // Time until next fire of plant.
    private float fireTimer;

    // Prefab of projectile that plant fires.
    public GameObject projectilePrefab;

    // Location of projectile spawn relative to plant.
    public Vector2 projectileSpawnLocation = new Vector2(0.45f, 0.26f);

    private void Update()
    {
        // Tick down the timer and fire when timer reaches 0.
        fireTimer -= Time.deltaTime;
        if (fireTimer < 0)
            Fire();
    }

    private void Fire()
    {
        // Spawn projectile
        GameObject projectileObject = Instantiate(projectilePrefab, transform.position + projectileSpawnLocation, Quaternion.identity);

        // Reset time until next fire of plant.
        fireTimer = fireInterval;
    }
}
