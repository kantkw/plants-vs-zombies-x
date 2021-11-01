using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePlantController : PlantController
{
    public float fireInterval;
    float fireTimer;

    public GameObject projectilePrefab;

    void Update()
    {
        fireTimer -= Time.deltaTime;
        if (fireTimer < 0)
            Fire();
    }

    public void Fire()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, GetComponent<Rigidbody2D>().position + new Vector2(0.5f, 0.2f), Quaternion.identity);

        ProjectileController projectile = projectileObject.GetComponent<ProjectileController>();
        projectile.Fire();

        fireTimer = fireInterval;
    }
}
