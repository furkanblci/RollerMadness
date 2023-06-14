using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public bool gameFinished = false;
    public bool gameOver = false;
    [SerializeField] private float LevelFinishTime = 5f;
    [SerializeField] private Text timeText;
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private GameObject GameOverPanel;

    private List<GameObject> destroyAfterGame = new List<GameObject>(); //oyun sonland�ktan sonra destroy edileceklerin listesi

 
    
    void Start()
    {
      
    }

  
    void Update()
    {
        if (!gameFinished && !gameOver)
        {
            UpdateTheTimer();

        }


        if (Time.timeSinceLevelLoad >=LevelFinishTime&& gameOver==false) //oyun ba�lang�� zaman� level biti� zaman�ndan b�y�kse ve oyunu kaybetmemi�sek �art�
        {
            gameFinished = true;
            WinPanel.gameObject.SetActive(true);
            GameOverPanel.gameObject.SetActive(false);

            UpdateObjectsList("Objects");
            UpdateObjectsList("Enemy");
            foreach (GameObject allObjects in destroyAfterGame)
            {
                Destroy(allObjects);
            }


        }

        if (gameOver==true)
        {
            WinPanel.gameObject.SetActive(false);
            GameOverPanel.gameObject.SetActive(true);

            UpdateObjectsList("Objects");
            UpdateObjectsList("Enemy");
            foreach (GameObject allObjects in GameObject.FindGameObjectsWithTag("Objects"))
            {
                Destroy(allObjects);
            }

        }
    }


    private void UpdateObjectsList(string tag)
    {
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag(tag));
        destroyAfterGame.AddRange(GameObject.FindGameObjectsWithTag(tag));
    }

    private void UpdateTheTimer()
    {
        timeText.text = "Time: " + (int)Time.timeSinceLevelLoad;
    }


}
