using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentTiling: MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public GameObject[] corridor;

    public void ActivateRandomCorridor()    //spawnaa randomilla käytävä-prefabeja
    {
        DeactivateAllCorridors();

        System.Random random = new System.Random();
        int randomNumber = random.Next(0, corridor.Length);
        corridor[randomNumber].SetActive(true);
    }

    public void DeactivateAllCorridors()
    {
        for (int i = 0; i < corridor.Length; i++)
        {
            corridor[i].SetActive(false);
        }
    }
}