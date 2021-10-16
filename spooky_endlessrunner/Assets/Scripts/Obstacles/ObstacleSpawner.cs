using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject door;
    public float waitSecondsMin;
    public float waitSecondsMax;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnerCoroutine());
    }


    IEnumerator SpawnerCoroutine()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(Random.Range(waitSecondsMin, waitSecondsMax));
            Instantiate(door, new Vector3(Random.Range(-2f, 2f), transform.position.y, transform.position.z), transform.rotation);

        }
    }
}
