using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Rock : Weapon
{

    Rigidbody2D rb2d;

    Vector2 force;

     void Start()
     {
        rb2d = GetComponent<Rigidbody2D>();
        force = new Vector2(GetShootDirection() * 10, 100);
        
        Move();

     }
    

    public override void Move()
    {
        rb2d.AddForce(force);  
    }
    


    public override void OnHitWith(Character character)
    {

        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }

    }

}