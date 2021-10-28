using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{

    public Light spotLight;
    public static float lightIntensity;
    public float reduceSpeed;


    // Start is called before the first frame update
    void Start()
    {
        lightIntensity = 15;
        spotLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        lightIntensity -= Time.deltaTime;
        spotLight.intensity = lightIntensity;
    }

    public void IncreaseIntensity()
    {
        lightIntensity = 15;
    }
}