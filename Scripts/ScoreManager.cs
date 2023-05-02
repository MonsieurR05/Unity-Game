using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    private int totalScore;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score: " + totalScore.ToString();
        highscoreText.text = "HighScore: " + highscore.ToString();
    }

    // Update is called once per frame
    public void AddPoint(int score)
    {
        totalScore += score;
        scoreText.text = "Score: " + totalScore.ToString();
        if (highscore < totalScore)
        PlayerPrefs.SetInt("highscore", totalScore);
    }
}
