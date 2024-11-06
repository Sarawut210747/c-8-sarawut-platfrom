using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    public void Start()
    {
        Damage = 30;
        speed = 4f * GetShootDiection();
        Move();
        
    }


    [SerializeField] private float speed;

    public override void Move()
    {
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
    }
}
