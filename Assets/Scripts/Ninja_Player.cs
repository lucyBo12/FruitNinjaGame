using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ninja_Player : MonoBehaviour
{

    public string stopGame;
    public AudioSource slice;
    public AudioSource burst;
    private Vector3 pos;
    public static int score = 0; //player score
    public static int oldScore;
    public static int highScore = 0;

    //lives
    public static int currentLife = 3;
    public GameObject[] lives;
    public static bool dead = false;



    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //Set screen orientation to landscape
        Screen.orientation = ScreenOrientation.LandscapeLeft;

        //Set sleep timeout to never
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        //currentLife = 3;

        

    }

    // Update is called once per frame
    void Update()
    {

        //if running on iphone
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //if touching screen
            if (Input.touchCount == 1)
            {
                //Find screen touch position by transforming position from screen space into game world space
                pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 1));

                //set player object pos
                transform.position = new Vector3(pos.x, pos.y, 3);

                GetComponent<Collider2D>().enabled = true;
                return;

            }
            //Set collider to false
            GetComponent<Collider2D>().enabled = false;

        }
        else
        {
            //find mouse pos
            pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

            //set position
            transform.position = new Vector3(pos.x, pos.y, 3);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Fruit")
        {
            slice.Play();
           // other.GetComponent<Gravity>().enabled = false;
            other.GetComponent<Fruit2D>().Hit();
            if(other.name == "Apple2D(Clone)")
            {
                score++;
            }
            else
            {
                score = score + 2;
            }
            

        }
        else if (other.tag == "Bomb")
        {
            burst.Play();
            other.GetComponent<Fruit2D>().Hit();
            LoseLife();
            
        }
    }


    /**
     * Takes away life from player
     * removes heart from ui
     * if all 3 lives are gone, exits to main menu
     */
    public void LoseLife()
    {

        
        
        Destroy(lives[currentLife - 1].gameObject);
        currentLife--;

        if (currentLife==0)
        {
            dead = true;
            Debug.Log("DED");
            oldScore = score;
            if(score > highScore)
            {
                highScore = score;
                //saves high score
                PlayerPrefs.SetFloat("Highscore", highScore);
            }
            new WaitForSeconds(2);
            SceneManager.LoadScene("MainMenu");
        }
        
    }
}
