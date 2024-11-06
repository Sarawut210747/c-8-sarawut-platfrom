using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        force = new Vector2(GetShootDiection() * 10, 100);
        
        Damage = 40;
        Move();
    }


     private Rigidbody2D rb2d;
     private Vector2 force;

    public override void Move()
    {
        rb2d.AddForce(force);  
        //Debug.Log("Rock is Moveing with rigidbody force");
    }
    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }
    }
}
