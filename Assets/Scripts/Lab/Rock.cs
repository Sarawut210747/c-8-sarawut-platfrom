using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon

{
<<<<<<< HEAD

    Rigidbody2D rb2d;

    Vector2 force;


    void Start()

    {

=======
    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        force = new Vector2(GetShootDiection() * 10, 100);
        
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
        Damage = 40;

        Move();
<<<<<<< HEAD

    }




    public override void Move()

    {


=======
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
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
    }


    public override void OnHitWith()

    {

        

    }

}