using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()  //Lataa ekan kent�n kun painaa play-nappia
    {
        SceneManager.LoadScene("Level1");
    }

    public void Quit()  //Poistuu pelist� 
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}