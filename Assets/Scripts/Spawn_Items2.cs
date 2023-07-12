using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Items2 : MonoBehaviour
{
    public float spawnTime = 1.7f; //spawn time
    public float timeUntilIncrease = 10;
    public static int noOfIncreases = 17;
    public GameObject apple; //apple prefab
    public GameObject bomb; //bomb prefab
    public GameObject orange;
    public float upForce = 750; //up force
    public float leftRightForce = 200; //horizontal force
    public float maxX = -7; // max x spawn position
    public float minX = 7; //min x spawn position

    // Start is called before the first frame update
    void Start()
    {
        //start spawn update
        StartCoroutine(Spawn(spawnTime));

    }

    IEnumerator Spawn(float delayOne)
    {
        //countdownRate is the time until the spawn rate will increase
        float countdownRate = timeUntilIncrease;
        //countdown is the time until the next object will spawn
        float countdown = delayOne;
        while(true)
        {
            yield return null;
            //take away real time passed
            countdownRate -= Time.deltaTime;
            countdown -= Time.deltaTime;

            //spawn object
            if(countdown < 0)
            {
                //reset spawn counter
                countdown += spawnTime;
                GameObject prefab = apple;
                upForce = 650;

                //if random is over 30
                if (Random.Range(0, 100) < 30)
                {
                    //Spawn prefab is bomb
                    prefab = bomb;
                    //GameObject go = Instantiate(prefab, new Vector3(Random.Range(minX, maxX + 1), transform.position.y, 0f),
                    //Quaternion.Euler(0, 0, Random.Range(-90F, 90F))) as GameObject;

                }
                if (Random.Range(0, 100) <30)
                {
                    //spawn orange
                    prefab = orange;
                    //GameObject go = Instantiate(prefab, new Vector3(Random.Range(minX, maxX + 1), transform.position.y, 0f), 
                       // Quaternion.Euler(0, 0, Random.Range(-90F, 90F))) as GameObject;
                    upForce = 750;

                }
                

                //spawn prefab at random position
                GameObject go = Instantiate(prefab, new Vector3(Random.Range(minX, maxX + 1), transform.position.y, 0f),
                    Quaternion.Euler(0, 0, Random.Range(-90F, 90F))) as GameObject;

                //if x is over 0 go left
                if (go.transform.position.x > 0)
                {
                    go.GetComponent<Rigidbody2D>().AddForce(new Vector2(-leftRightForce, upForce));
                }
                //else go right
                else
                {
                    go.GetComponent<Rigidbody2D>().AddForce(new Vector2(leftRightForce, upForce));
                }
            }
            if (countdownRate <= 0 && spawnTime > 0 && noOfIncreases > 0)
            {
                Debug.Log("Increase!!");
                countdownRate += timeUntilIncrease;
                spawnTime -= 0.1f;
                noOfIncreases--;
            }
        }
        
        

        

        //start spawn again
        //StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
