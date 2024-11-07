using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{

    public void Start()
    {
        Damage = 30;
        speed = 4f;
        Move();
        //OnHitWith();
    }



    [SerializeField] private float speed;

    public override void Move()
    {
        Debug.Log("Banana is moving with transform constant speed");

    }




    public override void OnHitWith(Character character)
    {


    }

}
