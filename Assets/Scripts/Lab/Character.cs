using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }

    }

    public Animator anim;
    public Rigidbody2D rb;

    public virtual void Init(int newHealth)
    {
        health = newHealth;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public bool Isdead()
    {
        return Health <= 0;

    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"()");
    }
}

