using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnvironmentGenerator : MonoBehaviour
{
    
    public Camera mainCamera;
    public Transform startPoint; 
    public EnvironmentTiling tilePrefab;
    public float movingSpeed = 10;
    public int tilesToPreSpawn;

    public int score;
    public int highScore;

    List<EnvironmentTiling> spawnedTiles = new List<EnvironmentTiling>();
    
    public static EnvironmentGenerator instance;

    // Start is called before the first frame update
    void Start()    //spawnaa skenen alussa heti jonoon sopivan m‰‰r‰n prefabeja
    {
        instance = this;
        Vector3 spawnPosition = startPoint.position;
        
        for (int i = 0; i < tilesToPreSpawn; i++)
        {
            spawnPosition -= tilePrefab.startPoint.localPosition;
            EnvironmentTiling spawnedTile = Instantiate(tilePrefab, spawnPosition, Quaternion.identity) as EnvironmentTiling;          
                        
            spawnedTile.ActivateCorridor();
            
            spawnPosition = spawnedTile.endPoint.position;
            spawnedTile.transform.SetParent(transform);
            spawnedTiles.Add(spawnedTile);
        }
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()   //prefabien liikkuminen
    {
        
        transform.Translate(-spawnedTiles[0].transform.forward * Time.deltaTime * movingSpeed, Space.World);
        score += 1;

        PlayerPrefs.SetInt("Score", score);

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        if (mainCamera.WorldToViewportPoint(spawnedTiles[0].endPoint.position).z < 0)
        {
            // Despawnaa ns. kameran taakse j‰‰v‰t prefabit ja spawnaa ne uudestaan startpointtiin
            EnvironmentTiling tileTmp = spawnedTiles[0];
            spawnedTiles.RemoveAt(0);
            tileTmp.transform.position = spawnedTiles[spawnedTiles.Count - 1].endPoint.position - tileTmp.startPoint.localPosition;
            tileTmp.ActivateCorridor();
            spawnedTiles.Add(tileTmp);
        }        
    }

    void OnDisable()
    {
        
    }
}