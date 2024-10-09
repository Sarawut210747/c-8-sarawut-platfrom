using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    protected string OwnerIShootable;

    public int GetShootDirection()
    {
        return 1;
    }

    public abstract void OnHitWith(Character character);
    public abstract void Move();
}
