using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject candle;
    public float waitSecondsMin;
    public float waitSecondsMax;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CandleCoroutine());
    }

IEnumerator CandleCoroutine()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(Random.Range(waitSecondsMin, waitSecondsMax));
            Instantiate(candle, new Vector3(Random.Range(-1.5f, 1.5f), transform.position.y, transform.position.z), transform.rotation);
        }
    }
}