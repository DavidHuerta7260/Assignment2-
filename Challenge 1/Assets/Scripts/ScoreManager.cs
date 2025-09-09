/*
David Huerta
Challenge 1
Displays score, checks win/loss, and restarts the scene.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Transform player;
    public Text scoreText;     
    public Text messageText;   
    public int winScore = 5;

    public int score;          
    public bool gameOver;

    void Start()
    {
       
        score = 0;
        gameOver = false;
        if (messageText != null) messageText.text = "";
        UpdateScoreText();
    }

    void Update()
    {
        
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            return;
        }

        if (gameOver) return;

        
        if (player != null)
        {
            float y = player.position.y;
            if (y > 80f || y < -51f)
            {
                SetGameOver("Game Over!\nPress R to restart");
            }
        }

        
        if (score >= winScore)
        {
            SetGameOver("You Win!\nPress R to restart");
        }
    }

    public void AddScore(int amount)
    {
        if (gameOver) return;
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    void SetGameOver(string msg)
    {
        gameOver = true;
        if (messageText != null) messageText.text = msg;
    }
}
