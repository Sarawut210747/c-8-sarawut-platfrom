using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable 
{
<<<<<<< HEAD
     GameObject Bullet {  get; set; }
     Transform BulletSpawnPoint {  get; set; }
    float BulletSpawnTime {  get; set; }
    float BulletTimer {  get; set; }

=======
    GameObject Bullet { get; set; }
    Transform SpawnPoint { get; set; }
    float ReloadTime { get; set; }
    float WaitTime { get; set; }
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
    void Shoot();
}
