using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentTiling: MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public GameObject[] corridor;

    public void ActivateCorridor()    //spawnaa k�yt�v�-prefabeja
    {
        corridor[0].SetActive(true);
    }
}