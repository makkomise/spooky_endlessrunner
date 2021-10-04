using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentTiling: MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public GameObject[] corridor;

    public void ActivateCorridor()    //spawnaa käytävä-prefabeja
    {
        System.Random random = new System.Random();
        int randomNumber = random.Next(0, corridor.Length);
        corridor[randomNumber].SetActive(true);
    }
}