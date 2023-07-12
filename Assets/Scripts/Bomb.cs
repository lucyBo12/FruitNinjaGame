using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Fruit2D
{
    public Bomb() { }


    public override void Hit()
    {

        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
        

    }

}