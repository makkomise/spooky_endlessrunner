using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text score;
    public Text highScore;


    void Update()
    {
        int scoreNumber = PlayerPrefs.GetInt("Score", 0);
        score.text = "SCORE: " + scoreNumber.ToString();

        int highScoreNumber = PlayerPrefs.GetInt("HighScore", 0);
        highScore.text = "HIGHSCORE: " + highScoreNumber.ToString();
    }

    
    public void Restart()  //Lataa ekan kentän kun painaa play-nappia
    {
        RenderSettings.fogDensity = 0.001f;
        SceneManager.LoadScene("Level1");
    }

    public void MainMenu()  //lataa mainmenun
    {
        SceneManager.LoadScene("MainMenu");
    }
}
