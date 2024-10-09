using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rock : Weapon
{
    void Start()
    {
        Damage = 40;
        Move();
        rb2d = GetComponent<Rigidbody2D>();
    }
    private Rigidbody2D rb2d;
    private Vector2 force;

    public override void Move()
    {
        Debug.Log("Rock moves with RigidBody: force");

        if (rb2d != null)
        {
            rb2d.AddForce(new Vector2(100f, 200f));
        }
    }

    public override void OnHitWith(Character character)
    {

    }
}
