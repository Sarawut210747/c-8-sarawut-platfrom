using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy, IShootable
{

    [SerializeField] private float attackRange;
    [SerializeField] public Player player;
    [field : SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform SpawnPoint { get; set; }
    [field: SerializeField] public float ReloadTime { get; set; }
    [field: SerializeField] public float WaitTime { get; set; }
    
    private void Update()
    {

        WaitTime -= Time.deltaTime;

        Behavior();
    }
    public override void Behavior()
    {
        Vector3 direction = player.transform.position - transform.position;
        float dirstance = direction.magnitude;
        

        if (dirstance < attackRange && WaitTime <= 0 )
        {
            Shoot();
        }
    }
    public void Shoot()
    {
         Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
         WaitTime = ReloadTime; 
    }

}
