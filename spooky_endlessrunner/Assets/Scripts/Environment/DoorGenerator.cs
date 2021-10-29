using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGenerator: MonoBehaviour
{

    public GameObject door;
    public float waitSecondsMin;
    public float waitSecondsMax;

    public GameObject animatedDoor;
    public float animWaitSecondsMin;
    public float animWaitSecondsMax;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoorPrefabCoroutine());
        StartCoroutine(AnimatedDoorPrefabCoroutine());  
    }

    IEnumerator DoorPrefabCoroutine()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(Random.Range(waitSecondsMin, waitSecondsMax));
            Instantiate(door, new Vector3(2f, transform.position.y, transform.position.z), transform.rotation); 
            yield return new WaitForSeconds(Random.Range(waitSecondsMin, waitSecondsMax));
            Instantiate(door, new Vector3(-2f, transform.position.y, transform.position.z), transform.rotation);
        }
    }
    IEnumerator AnimatedDoorPrefabCoroutine()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(Random.Range(waitSecondsMin, waitSecondsMax));
            Instantiate(animatedDoor, new Vector3(2f, transform.position.y, transform.position.z), transform.rotation);
            yield return new WaitForSeconds(Random.Range(waitSecondsMin, waitSecondsMax));
            Instantiate(animatedDoor, new Vector3(-2f, transform.position.y, transform.position.z), transform.rotation);
        }
    }
}
