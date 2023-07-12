using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit2D
{
    public Apple() { }


    public override void Hit()
    {


        Instantiate(splat, transform.position, transform.rotation);
        Instantiate(points, transform.position + new Vector3(-2, 0, 0), transform.rotation);
        Destroy(gameObject);
        

    }

}