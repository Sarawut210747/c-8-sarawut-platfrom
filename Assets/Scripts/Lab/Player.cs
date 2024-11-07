using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

<<<<<<< HEAD
public class Player : Banana ,IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    private void Update()
    {
        BulletTimer -= Time.deltaTime;
        if (Input.GetButtonDown("1") && BulletTimer <= 0)
        {
            Shoot();

        }
       
=======
public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform SpawnPoint { get; set; }
     public float ReloadTime { get; set; }
     public float WaitTime { get; set; }

    private void Update()
    {
        Shoot();
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
    }

    public void Shoot()
    {
<<<<<<< HEAD
        if (BulletTimer <= 0)
        {
            Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);

            BulletTimer = BulletSpawnTime;
        }

=======
        if(Input.GetButtonDown("Firel") && WaitTime >= ReloadTime)
        {
            GameObject obj = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            Banana banana = obj.GetComponent<Banana>();
            banana.Init(10, this);
            WaitTime = 0;
        }
        
    }

    private void Start()
    {
        WaitTime = 0.0f;
        ReloadTime = 1.0f;
    }

    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if(enemy != null)
        {
            OnHitWith(enemy);
        }
    }

    void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
    }
}
