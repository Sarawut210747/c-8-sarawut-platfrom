using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour

{
<<<<<<< HEAD

    [SerializeField] int damage = 0;

    public int Damage { get { return damage; } set { damage = value; } }


    protected string owner;


    //abstract methods

    public abstract void OnHitWith();
=======
    private int damage;
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

    public IShootable shooter;
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164

    public abstract void Move();
<<<<<<< HEAD


    public void Init(int _damage, string _owner)

    {

        Damage = _damage;

        owner = _owner;

    }


    public int GetShootDirection() //to be modify

    {

        return 1;

    }


    private void OnTriggerEnter2D(Collider2D other) //add later

    {

        //OnHitWith(other.GetComponent<Character>());

      

    }

}
=======
    public void Init(int _damage, IShootable _owner)
    {
        Damage = _damage;
        shooter = _owner;
    }
    public int GetShootDiection()
    {
        float shootDir = shooter.SpawnPoint.transform
            .position.x - shooter.SpawnPoint.parent.transform.position.x;
        if (shootDir < 0) 
        return -1;
        else
            return 1;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
        Destroy(this.gameObject, 5f);
    }


}
>>>>>>> 2fa78be821a34fd5d0d03d5bbf69e2b70af8a164
