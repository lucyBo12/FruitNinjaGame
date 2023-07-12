using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public string newGame;


    [SerializeField] public TextMeshProUGUI scoreText; //score text
    [SerializeField] public TextMeshProUGUI highScoreText; //highScore text
    public int score;
    public int highScore;
    public GameObject creditScreen;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Prev Score: " + Ninja_Player.oldScore;
        highScoreText.text = "High Score:" + PlayerPrefs.GetFloat("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * Called on 'New Game' Button press, starts new game
     * Loads 'NinjaGame' scene
     */
    public void NewGame()
    {
        SceneManager.LoadScene(newGame);
    }

    /**
     * Called on 'Quit Game' Button press, exits the application
     */
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void AchievementRoom()
    {
        SceneManager.LoadScene("AchievementRoom");
    }

    //brings up credit panel
    public void ShowCredits()
    {
        //creditScreen.SetActive(true);
        creditScreen.GetComponent<Animator>().SetBool("isActive", true);
    }

    //deactivates credit panel
    public void CreditBack()
    {
        //creditScreen.SetActive(false);
        creditScreen.GetComponent<Animator>().SetBool("isActive", false);
    }
}
