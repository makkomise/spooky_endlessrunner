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
    

    List<EnvironmentTiling> spawnedTiles = new List<EnvironmentTiling>();
    [HideInInspector]
    
    public static EnvironmentGenerator instance;

    // Start is called before the first frame update
    void Start()
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
    }

    // Update is called once per frame
    void Update()
    {
        // Liikuttaa prefabia tietyll� nopeudella
        // Kentt� muuttuu nopeemmaksi mit� enemm�n on "pisteit�" (t�ll� hetkell� pisteit� tulee ihan sit� mukaa mit� pitemp��n pysyy elossa)
        
            transform.Translate(-spawnedTiles[0].transform.forward * Time.deltaTime * movingSpeed, Space.World);
            
        

        if (mainCamera.WorldToViewportPoint(spawnedTiles[0].endPoint.position).z < 0)
        {
            // Despawnaa ns. kameran taakse j��v�t prefabit ja spawnaa ne uudestaan startpointtiin
            EnvironmentTiling tileTmp = spawnedTiles[0];
            spawnedTiles.RemoveAt(0);
            tileTmp.transform.position = spawnedTiles[spawnedTiles.Count - 1].endPoint.position - tileTmp.startPoint.localPosition;
            tileTmp.ActivateCorridor();
            spawnedTiles.Add(tileTmp);
        }

        
    }    
}