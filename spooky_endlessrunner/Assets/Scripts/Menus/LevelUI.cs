using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{

    public Text score;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        int scoreNumber = PlayerPrefs.GetInt("Score", 0);
        score.text = "SCORE: " + scoreNumber.ToString();
    }
}
