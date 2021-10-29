using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog: MonoBehaviour
{
    public float fogDensity = 0.002f;

    // Update is called once per frame
    void Update()
    {
        fogDensity += Time.deltaTime / 300;
        RenderSettings.fogDensity = fogDensity;
    }
}
