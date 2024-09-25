using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{   Vector2 velocity;
    Transform[] movePoints;

    public override void Behavior()
    {
        Debug.Log("Hi i'm ant");
    }
}
   
