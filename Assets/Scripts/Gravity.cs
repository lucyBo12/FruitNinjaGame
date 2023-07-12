using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Vector3 acceleration;
    private Vector3 gravity;
    private Vector3 push;
    private Vector3 velocity;
    private float mass = 10.0f;


    //applies gravity force
    public void ApplyForce(Vector3 force)
    {
        Vector3 a = force / mass; //F=ma , a=F/m
        acceleration += a; //added to acceleration for new acceleration speed

    }

    //updates position of the object
    private void UpdatePosition()
    {
        velocity = velocity + acceleration; // change  in direction
        //new position of gameobject, Time.deltaTime so game runs at same speed regardless of fps
        transform.position += velocity * Time.deltaTime;
        acceleration = new Vector3(0.0f, 0.0f); //resets to 0
    }

    // Start is called before the first frame update
    void Start()
    {
        gravity = new Vector3(0, -1, 0); //y = -1
        push = new Vector3(0, 100, 0); //upwards.., // push = new Vector3(50, 50, 0); - updwards right
        ApplyForce(push); //unlike gravity, only applied once at start
    }

    // Update is called once per frame
    void LateUpdate()
    {
        ApplyForce(gravity);
        UpdatePosition();
    }
}
