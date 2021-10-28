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
        
        scoreText.text = "SCORE: " + EnvironmentGenerator.instance.score.ToString();
    }

    
    public void Restart()  //Lataa ekan kentän kun painaa play-nappia
    {
        SceneManager.LoadScene("Level1");
    }

    public void MainMenu()  //lataa mainmenun
    {
        SceneManager.LoadScene("MainMenu");
    }
}
