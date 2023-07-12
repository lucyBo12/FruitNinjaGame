using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fruit2D : MonoBehaviour
{
    

    public Fruit2D() { } //constructor

    private bool canBeDead;
    private Vector3 screen;
    public GameObject player;
    public GameObject splat;
    public GameObject explosion;
    public GameObject points;


    // Update is called once per frame
    private void Start()
    {
    }
    void Update()
    {
        //set screen position
        screen = Camera.main.WorldToScreenPoint(transform.position);

        //if can die and not on screen
        if(canBeDead && screen.y <-20)
        {
            Destroy(gameObject);
        }
        //if cant die and are on screen
        //for fruit to appear on screen the first time
        else if(!canBeDead && screen.y > -10)
        {
            canBeDead = true;
        }
    }

    public virtual void Hit()
    {
        if (gameObject.tag == "Fruit")
        {
            Instantiate(splat, transform.position, transform.rotation);
        }
        Destroy(gameObject);

        if(gameObject.tag == "Bomb")
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
