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
        if (lightIntensity > 0.001) //pienent‰‰ lampun valon m‰‰r‰‰ pikkuhiljaa
        {
            lightIntensity -= Time.deltaTime;
            spotLight.intensity = lightIntensity;
        }
        else
        {
            return;
        }        
    }

    public void IncreaseIntensity() //lis‰‰ valon m‰‰r‰‰ 
    {
        if (lightIntensity <= 15)
        {
            lightIntensity = lightIntensity + 5;
        }
        if (lightIntensity > 15)
        {
            lightIntensity = 15;
        }
    }
}