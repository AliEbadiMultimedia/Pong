
using System;
using UnityEngine;

public class ScoreAreaComputer : MonoBehaviour
{
    public GameController GameController;
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameController.IncreaseComputerScore();
    }
}