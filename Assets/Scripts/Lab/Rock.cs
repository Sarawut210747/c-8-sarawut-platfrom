using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rock : Weapon

{

    Rigidbody2D rb2d;

    Vector2 force;


    void Start()

    {

        Damage = 40;

        Move();

    }




    public override void Move()

    {


    }


    public override void OnHitWith()

    {

        

    }

}