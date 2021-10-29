using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog: MonoBehaviour
{
    public float fogDensity = 0.001f;

    // Update is called once per frame
    void Update()
    {
        fogDensity += Time.deltaTime / 200;
        RenderSettings.fogDensity = fogDensity;
    }
}
