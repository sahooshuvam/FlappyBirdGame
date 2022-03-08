using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public void ScoreManager(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log("Score: " +score);
        scoreText.text = score.ToString();
    } 
}
