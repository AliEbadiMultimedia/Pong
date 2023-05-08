using UnityEngine;

public class ScoreAreaPlayer : MonoBehaviour
{
    public GameController GameController;
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameController.IncreasePlayerScore();
    }
}