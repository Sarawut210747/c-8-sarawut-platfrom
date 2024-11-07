using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
<<<<<<< HEAD

    public void Start()
    {
       
        speed = 4f;
        Move();
        OnHitWith();
    }



=======
    public void Start()
    {
        Damage = 30;
        speed = 4f * GetShootDiection();
        Move();
        
    }


>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
    [SerializeField] private float speed;

    public override void Move()
    {
<<<<<<< HEAD
      
    }




    public override void OnHitWith()
    {


=======
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newposition = new Vector2(newX, newY);
        transform.position = newposition;
        //Debug.Log("Banana moveing with transform");
    }
    private void FixedUpdate()
    {
        Move();
    }
    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(this.Damage);
        }
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
    }

}
