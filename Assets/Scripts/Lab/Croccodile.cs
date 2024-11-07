using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodile : Enemy, IShootable
{
    [SerializeField] private float attackRange;
    public Player player;

    [field : SerializeField] public GameObject Bullet { get; set; }
    [field : SerializeField] public Transform BulletSpawnpoint { get; set; }
    [field : SerializeField] public float BulletSpawnTime { get; set; }
    [field : SerializeField] public float BulletTimer { get; set; }


    public void Update()
    {
        BulletTimer -= Time.deltaTime;
        Behavior();
    }
    public override void Behavior()
    {
        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange && BulletTimer <= 0)
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        if (BulletTimer <= 0)
        {
            Instantiate(Bullet, BulletSpawnpoint.position, Quaternion.identity);

            BulletTimer = BulletSpawnTime;
        }

    }
}