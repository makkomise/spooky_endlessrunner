using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float movingSpeed = 10;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 6f);
    }

    // Update is called once per frame
    void Update()
    {            
        transform.Translate(Vector3.back * Time.deltaTime * (movingSpeed + (score / 500)), Space.World);
        score += Time.deltaTime * movingSpeed;
        
    }
}
