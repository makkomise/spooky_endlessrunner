using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text Score;

    
    public void Restart()  //Lataa ekan kent�n kun painaa play-nappia
    {
        SceneManager.LoadScene("Level1");
    }

    public void MainMenu()  //lataa mainmenun
    {
        SceneManager.LoadScene("MainMenu");
    }
}
