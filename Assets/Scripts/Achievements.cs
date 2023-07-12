using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Achievements : MonoBehaviour
{

    //sorry this class isnt very efficient :<
    
    public GameObject achievement;
    public GameObject achievementIcon;
    public TextMeshProUGUI achievementTitle;
    public TextMeshProUGUI achievementDesc;
    public bool isActive;
    public int score;

    //achievment 1 variables
    private static bool gotAchievement1;
    private int achiev1Goal = 10;

    //achievment 2 variables
    private int achiev2Goal = 50;
    private static bool gotAchievement2;

    //achievment 3 variables
    private int achiev3Goal = 100;
    private static bool gotAchievement3;

    //achievment 4 variables
    private int achiev4Goal = 200;
    private static bool gotAchievement4;

    //achievement 5 variables
    private int achiev5Goal = 0;
    private static bool gotAchievement5;

    //achievement 6 variables 
    private int achiev6Goal = 0;
    private static bool gotAchievement6;


    // Update is called once per frame
    void Update()
    {
        score = Ninja_Player.score;

        //condition checks for achievements
        if(score > achiev1Goal && PlayerPrefs.GetInt("Achievement1") != 1)
        {
            StartCoroutine(Achievement1());
        }

        if(score > achiev2Goal && PlayerPrefs.GetInt("Achievement2") != 1)
        {
            StartCoroutine(Achievement2());
        }

        if(score > achiev3Goal && PlayerPrefs.GetInt("Achievement3") !=1)
        {
            StartCoroutine(Achievement3());
        }

        if(score > achiev4Goal && PlayerPrefs.GetInt("Achievement4") !=1)
        {
            StartCoroutine(Achievement4());
        }

        if(score == achiev5Goal && Ninja_Player.dead == true && PlayerPrefs.GetInt("Achievement5") !=1)
        {
            StartCoroutine(Achievement5());
        }

        if(Spawn_Items2.noOfIncreases == 0 && Ninja_Player.currentLife == 3 && PlayerPrefs.GetInt("Achievement6") !=1)
        {
            StartCoroutine(Achievement6());
        }
    }


    //Achievement 1 - score over 10 points
    IEnumerator Achievement1()
    {
        isActive = true;

        //set text for achievement
        achievementTitle.text = "Novice";
        achievementDesc.text = "Get over 10 points";
        //show achievemnt
        achievement.SetActive(true);
        //achievementIcon.SetActive(true);

        //saves achievement so player cant get it multiple times
        PlayerPrefs.SetInt("Achievement1", 1);
        gotAchievement1 = true;

        //disable achievement after 5 seconds
        yield return new WaitForSeconds(5);

        achievementTitle.text = "";
        achievementDesc.text = "";
        achievement.SetActive(false);
        isActive = false;
        //achievementIcon.SetActive(false);
    }

    //Achievemnt 2 - score over 50 points
    IEnumerator Achievement2()
    {
        isActive = true;

        //set text for achievement
        achievementTitle.text = "Apprentice";
        achievementDesc.text = "Get over 50 points";
        //show achievemnt
        achievement.SetActive(true);
        //achievementIcon.SetActive(true);

        //saves achievement so player cant get it multiple times
        PlayerPrefs.SetInt("Achievement2", 1);
        gotAchievement2 = true;

        //disable achievement after 5 seconds
        yield return new WaitForSeconds(5);

        achievementTitle.text = "";
        achievementDesc.text = "";
        achievement.SetActive(false);
        isActive = false;
        //achievementIcon.SetActive(false);
    }

    //Achievemnt 3 - score over 100 points
    IEnumerator Achievement3()
    {
        isActive = true;

        //set text for achievement
        achievementTitle.text = "Adept";
        achievementDesc.text = "Get over 100 points";
        //show achievemnt
        achievement.SetActive(true);
        

        //saves achievement so player cant get it multiple times
        PlayerPrefs.SetInt("Achievement3", 1);
        gotAchievement3 = true;

        //disable achievement after 5 seconds
        yield return new WaitForSeconds(5);

        achievementTitle.text = "";
        achievementDesc.text = "";
        achievement.SetActive(false);
        isActive = false;
        
    }

    //Achievemnt 4 - score over 200 points
    IEnumerator Achievement4()
    {
        isActive = true;

        //set text for achievement
        achievementTitle.text = "Expert";
        achievementDesc.text = "Get over 200 points";
        //show achievemnt
        achievement.SetActive(true);


        //saves achievement so player cant get it multiple times
        PlayerPrefs.SetInt("Achievement4", 1);
        gotAchievement4 = true;

        //disable achievement after 5 seconds
        yield return new WaitForSeconds(5);

        achievementTitle.text = "";
        achievementDesc.text = "";
        achievement.SetActive(false);
        isActive = false;

    }
    //Achievement 5 - Lose game with a score of 0
    //need to work out how to get this to show on mainscreen scene
    IEnumerator Achievement5()
    {
        isActive = true;

        //set text for achievement
        achievementTitle.text = "No Fruit For You";
        achievementDesc.text = "Die with a score of 0";
        //show achievemnt
        achievement.SetActive(true);


        //saves achievement so player cant get it multiple times
        PlayerPrefs.SetInt("Achievement5", 1);
        gotAchievement5 = true;

        //disable achievement after 5 seconds
        yield return new WaitForSeconds(5);

        achievementTitle.text = "";
        achievementDesc.text = "";
        achievement.SetActive(false);
        isActive = false;

    }

    //Achievement 6 - reach max spawn speed with all lives
    IEnumerator Achievement6()
    {
        isActive = true;

        //set text for achievement
        achievementTitle.text = "Super Speed";
        achievementDesc.text = "Reach max spawn speed with 3 lives";
        //show achievemnt
        achievement.SetActive(true);


        //saves achievement so player cant get it multiple times
        PlayerPrefs.SetInt("Achievement6", 1);
        gotAchievement6 = true;

        //disable achievement after 5 seconds
        yield return new WaitForSeconds(5);

        achievementTitle.text = "";
        achievementDesc.text = "";
        achievement.SetActive(false);
        isActive = false;

    }
}
