using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog: MonoBehaviour
{
    public float fogDensity = 0.001f;
    public float reduceSpeed;
    

    // Update is called once per frame
    void Update()
    {
        fogDensity += Time.deltaTime / 100;
        RenderSettings.fogDensity = fogDensity;
    }
}
