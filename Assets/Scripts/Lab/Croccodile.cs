using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodile : Enemy
{
    [SerializeField] private float attackRange;
    public Player player;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnpoint;

    [SerializeField] private float bulletSpawnTime;
    [SerializeField] private float bulletTimer;


    public void Update()
    {
        bulletTimer -= Time.deltaTime;
        Behavior();
    }
    public override void Behavior()
    {
        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange)
        {
            shoot();
        }
    }
    private void shoot()
    {
        if (bulletTimer <= 0)
        {
            Instantiate(bullet, bulletSpawnpoint.position, Quaternion.identity);

            bulletTimer = bulletSpawnTime;
        }

    }
}
