using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodile : Enemy, IShootable
{
   private float attackRange;
   public float AttackRange { get { return attackRange; }set { attackRange = value; } }
   public Player player;
    
   [SerializeField]
   Transform spawnPoint;
   public Transform SpawnPoint { get { return spawnPoint; } set {  spawnPoint = value; } }

<<<<<<< HEAD
    [field : SerializeField] public GameObject Bullet { get; set; }
    [field : SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field : SerializeField] public float BulletSpawnTime { get; set; }
    [field : SerializeField] public float BulletTimer { get; set; }
=======
    [SerializeField]
    GameObject bullet;
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164


    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

    void Start()
    {
<<<<<<< HEAD
        BulletTimer -= Time.deltaTime;
        Behavior();
=======
        
        WaitTime = 0.0f;
        ReloadTime = 5.0f;
        DamageHit = 30;
        AttackRange = 6;
        player = GameObject.FindObjectOfType<Player>();
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
    }
    private void FixedUpdate()
    {
        WaitTime -= Time.fixedDeltaTime;
        Behavior();    

    }
   
    /* public void Shoot()
     {

     }*/

    public override void Behavior()
    {
<<<<<<< HEAD
        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange && BulletTimer <= 0)
=======
        Vector2 distance = player.transform.position - transform.position;
        
        if (distance.magnitude <= attackRange)
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
        {
            Shoot();
        }
    
    }
<<<<<<< HEAD
    public void Shoot()
    {
        if (BulletTimer <= 0)
        {
            Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);

            BulletTimer = BulletSpawnTime;
=======

    public void Shoot() 
    {
        if(WaitTime >= ReloadTime)
        {
            //animator.SetTrigger("Shoot");
            GameObject obj = Instantiate(bullet, spawnPoint.position, Quaternion.identity);
            Rock rock = obj.gameObject.GetComponent<Rock>();
            rock.Init(20,this);
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
        }
    

    
    }
<<<<<<< HEAD
}
=======

}
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
