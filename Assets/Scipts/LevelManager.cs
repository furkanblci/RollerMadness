using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   
   




    public void RestartLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void LoadNextLevel()
    {
        int nextScene›ndex = SceneManager.GetActiveScene().buildIndex + 1;

        int scene›ndex = SceneManager.sceneCountInBuildSettings - 1;

        if (nextScene›ndex<=scene›ndex)
        {
            SceneManager.LoadScene(nextScene›ndex);
        }

        if (nextScene›ndex>scene›ndex)
        {
            SceneManager.LoadScene(0);
        }

       
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

   
}

