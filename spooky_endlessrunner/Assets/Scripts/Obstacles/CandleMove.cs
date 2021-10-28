using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleMove : MonoBehaviour
{
    public float movingSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * movingSpeed, Space.World);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}