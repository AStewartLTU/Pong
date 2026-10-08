using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public BallController ball;

    public TMP_Text player1ScoreText;
    public TMP_Text player2ScoreText;
    public TMP_Text winnerText;

    private int player1Score = 0;
    private int player2Score = 0;

    void Awake()
    {
        instance = this;

        winnerText.text = "";
    }

    public void Player1Scores()
    {
        player1Score++;

        UpdateScore();

        CheckWinner();

        if (player1Score < 10)
        {
            ball.ResetBall();
        }
    }

    public void Player2Scores()
    {
        player2Score++;

        UpdateScore();

        CheckWinner();

        if (player2Score < 10)
        {
            ball.ResetBall();
        }
    }

    void UpdateScore()
    {
        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = player2Score.ToString();
    }

    void CheckWinner()
    {
        if (player1Score >= 10)
        {
            winnerText.text = "PLAYER 1 WINS!";
            Time.timeScale = 0f;
        }

        if (player2Score >= 10)
        {
            winnerText.text = "PLAYER 2 WINS!";
            Time.timeScale = 0f;
        }
    }
}
