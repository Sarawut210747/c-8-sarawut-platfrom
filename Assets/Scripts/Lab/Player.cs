using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform SpawnPoint { get; set; }
     public float ReloadTime { get; set; }
     public float WaitTime { get; set; }

    private void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
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
    }
}
