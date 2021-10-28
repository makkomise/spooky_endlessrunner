using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()  //Lataa ekan kentän kun painaa play-nappia
    { 
        SceneManager.LoadScene("Level1");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quit()  //Poistuu pelistä 
    {
        Application.Quit();
    }
}