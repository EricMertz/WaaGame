using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;
    public Text livesText;
    public Text gameOverText;
    public Text restartText;
    public int count;
    private int score;
    private bool gameOver;
    

    void Start()
    {
        
        gameOver = false;
        score = 0;
        gameOverText.text = "";
        restartText.text = "";
        UpdateScore();
        UpdateLives();
        
        
    }

    private void Update()
    {
        if (gameOver)
        {
            restartText.text = "Press 'R' for Restart";
            if (Input.GetKeyDown(KeyCode.R))
            {
                
                Application.LoadLevel(Application.loadedLevel);
                Time.timeScale = 1f;
            }
        }
    }
    public bool gamestate()
    {
        return gameOver;
    }

    public int get_count()
    {
        return count;
    }

    void UpdateLives()
    {
        livesText.text = "Lives: " + get_count();
    }

    public void TakeLife()
    {
        count--;
        UpdateLives();
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {

        gameOverText.text = "Game Over!";
        gameOver = true;
        Time.timeScale = 0f;
    }
}
