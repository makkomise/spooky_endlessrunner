using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour   //valonvälkkymistä tässä skriptissä juum
{

    public float intensityMin;
    public float intensityMax;
    public float intensitySpeed;
    float random;

    public Light roofLight;

    // Start is called before the first frame update
    void Start()
    {
        roofLight = GetComponent<Light>();
        random = Random.Range(0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        float noise = Mathf.PerlinNoise(random, Time.deltaTime * intensitySpeed);
        roofLight.intensity = Mathf.Lerp(intensityMin, intensityMax, noise);
    }
}
