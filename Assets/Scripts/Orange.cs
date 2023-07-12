using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : Fruit2D
{
    public Orange() {}


    public void Start()
    {
        StartCoroutine(ScaleDown(1));
    }
    public override void Hit()
    {
        
        Instantiate(splat, transform.position, transform.rotation);
        Instantiate(points, transform.position + new Vector3(-2, 0, 0), transform.rotation);
        Destroy(gameObject);

    }


    //make orange small over time 
    IEnumerator ScaleDown(float time)
    {
        Debug.Log("Pls work");
        float currentTime = 0;
        Vector3 originalSize = this.transform.localScale;
        Vector3 newSize = new Vector3(0.5f,0.5f,0.5f);

        do
        {
            //lerp - linear interpolation - so the oranges size can be gradually moved between the two sizes
            this.transform.localScale = Vector3.Lerp(originalSize, newSize, currentTime / time);
            //add real-time passed
            currentTime = currentTime + Time.deltaTime;

            yield return null;
        }
        while (currentTime <= time);
        {
            StartCoroutine(ScaleUp(1));
        }
        

    }


    //make orange big over time
    IEnumerator ScaleUp(float time)
    {
        Debug.Log("aaah");
        float currentTime = 0;
        Vector3 originalSize = this.transform.localScale;
        Vector3 newSize = new Vector3(2f, 2f, 2f);

        do
        {
            //lerp - linear interpolation - so the oranges size can be gradually moved between the two sizes
            this.transform.localScale = Vector3.Lerp(originalSize, newSize, currentTime / time);
            //add real-time passed
            currentTime = currentTime + Time.deltaTime;

            yield return null;
        }
        while (currentTime <= time);
        {
            StartCoroutine(ScaleDown(1));
        }


    }

}