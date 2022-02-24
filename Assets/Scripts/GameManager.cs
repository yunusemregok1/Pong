using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;


    private int playerScore;
    private int computerScore;

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }
    public void StartRound()
    {
        playerPaddle.ResetPositionPaddle();
        computerPaddle.ResetPositionPaddle();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
    public void PlayerScores()
    {
        SetPlayerScore(playerScore +10);
        StartRound();
    }
    public void ComputerScores()
    {
        SetComputerScore(computerScore +10);
        StartRound();

    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }
    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }
}
