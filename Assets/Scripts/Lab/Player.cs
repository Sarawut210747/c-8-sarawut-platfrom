using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Banana ,IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnpoint { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    private void Update()
    {
        BulletTimer = Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && BulletSpawnTime <= 0)
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
