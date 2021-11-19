using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nosferatu : MonoBehaviour
{
    public float distance;  //miten et��ll� nosferatu huomaa pelaajan
    private Transform target;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        if (Vector2.Distance(transform.position, target.position) > distance)
        {
            animator.SetBool("Active", true);
            Debug.Log("pr��t");
        }
        else
        {
            animator.SetBool("Active", false);
            Debug.Log("t�t� ei pit�is tapahtua");
        }
    }
}
