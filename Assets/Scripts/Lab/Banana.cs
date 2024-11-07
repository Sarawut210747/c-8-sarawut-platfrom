using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{

    public void Start()
    {
       
        speed = 4f;
        Move();
        OnHitWith();
    }



    [SerializeField] private float speed;

    public override void Move()
    {
      
    }




    public override void OnHitWith()
    {


    }

}
