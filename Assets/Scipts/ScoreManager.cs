using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;  //ba�ka scriptlerde de kullanabilmek i�in score de�i�kenini public yapt�m
    [SerializeField] private Text scoreText;

  
    private void Update()
    {
        UpdateScoreText();
    }
   private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();

    }


}
