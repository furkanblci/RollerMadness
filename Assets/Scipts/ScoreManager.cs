using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;  //baþka scriptlerde de kullanabilmek için score deðiþkenini public yaptým
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
