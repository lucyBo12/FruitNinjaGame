using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splat2D: MonoBehaviour
{
    private Color colour;
    public float destroySpeed = 0.2f; //destroy speed

    // Start is called before the first frame update
    void Start()
    {
        //set colour
        colour = GetComponent<SpriteRenderer>().color;
        
    }

    // Update is called once per frame
    void Update()
    {
        //set mesh material colour
        GetComponent<SpriteRenderer>().color = new Color(colour.r, colour.g, colour.b, colour.a -= destroySpeed * Time.deltaTime);

        //if colour a is 0
        if(colour.a <= 0)
        {
            Destroy(gameObject);
        }
        
    }
}
