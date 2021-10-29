using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentTiling: MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public GameObject[] obstacles;

    public void ActivateRandomCorridor()    //spawnaa käytävä-prefabeja
    {
        DeactivateAllObstacles();
        System.Random random = new System.Random();
        int randomNumber = random.Next(0, obstacles.Length);
        obstacles[randomNumber].SetActive(true);
    }
    public void DeactivateAllObstacles()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].SetActive(false);
        }
    }
}