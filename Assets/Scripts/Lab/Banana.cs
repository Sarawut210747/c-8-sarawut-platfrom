using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    void Start()
    {
        speed = 4f;
        Move();
        Damage = 30;
    }
    
    [SerializeField]private float speed;
   
    public override void Move()
    {
        Debug.Log("Banana moves with Transform at constant speed");

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    public override void OnHitWith(Character character)
    {
        
    }
}
