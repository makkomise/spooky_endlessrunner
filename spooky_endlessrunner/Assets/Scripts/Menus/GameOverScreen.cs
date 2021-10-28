using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;

    public void ScoreSetup(int score)
    {

        scoreText.text = "SCORE: ";
    }

    
    public void Restart()  //Lataa ekan kent�n kun painaa play-nappia
    {
        RenderSettings.fogDensity = 0.001f;
        SceneManager.LoadScene("Level1");

    }

    public void MainMenu()  //lataa mainmenun
    {
        SceneManager.LoadScene("MainMenu");
    }
}
