using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGenerator: MonoBehaviour
{

    public GameObject door;
    public float waitSecondsMin;
    public float waitSecondsMax;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnerCoroutine1());
        StartCoroutine(SpawnerCoroutine2());
    }    


    IEnumerator SpawnerCoroutine1()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(Random.Range(waitSecondsMin, waitSecondsMax));
            Instantiate(door, new Vector3(3f, transform.position.y, transform.position.z), transform.rotation);

        }
    }
    IEnumerator SpawnerCoroutine2()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(Random.Range(waitSecondsMin, waitSecondsMax));
            Instantiate(door, new Vector3(-3f, transform.position.y, transform.position.z), transform.rotation);

        }
    }
}
