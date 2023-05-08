using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int player1Score;
    public int player2Score;

    public TextMeshProUGUI player1Text;
    public TextMeshProUGUI player2Text;
        


    void Start()
    {
        player1Score = player2Score = 0;
    }

    public void IncreasePlayerScore()
    {
        player1Score++;
        UpdatePlayerScore();
    }

    public void IncreaseComputerScore()
    {
        player2Score++;
        UpdatePlayerScore();
    }

    void UpdatePlayerScore()
    {
        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();
    }
}