using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AchievementRoom : MonoBehaviour
{
    //Achievement trophies
    public GameObject achievement1;
    public GameObject achievement2;
    public GameObject achievement3;
    public GameObject achievement4;
    public GameObject achievement5;
    public GameObject achievement6;
    public TextMeshProUGUI achievement1text;
    public TextMeshProUGUI achievement2text;
    public TextMeshProUGUI achievement3text;
    public TextMeshProUGUI achievement4text;
    public TextMeshProUGUI achievement5text;
    public TextMeshProUGUI achievement6text;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("helLO?");
        //work out whether trophies are visible
        if(PlayerPrefs.GetInt("Achievement1") == 1)
        {

            achievement1.SetActive(true);
            achievement1text.text = "Novice";
        }
        if (PlayerPrefs.GetInt("Achievement2") == 1)
        {
            achievement2.SetActive(true);
            achievement2text.text = "Apprentice";
        }
        if (PlayerPrefs.GetInt("Achievement3") == 1)
        {
            achievement3.SetActive(true);
            achievement3text.text = "Adept";
        }
        if (PlayerPrefs.GetInt("Achievement4") == 1)
        {
            achievement4.SetActive(true);
            achievement4text.text = "Expert";
        }
        if (PlayerPrefs.GetInt("Achievement5") == 1)
        {
            achievement5.SetActive(true);
            achievement5text.text = "No Fruit For You!";
        }
        if (PlayerPrefs.GetInt("Achievement6") == 1)
        {
            achievement6.SetActive(true);
            achievement6text.text = "Super Speed";
        }
    }

    //return to main menu
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
