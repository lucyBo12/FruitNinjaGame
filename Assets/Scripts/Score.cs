using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject player;
    [SerializeField] public TextMeshProUGUI scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        score = Ninja_Player.score;
        //displays player score on screen
        scoreText.text = "Score: " + score;
    }
}
