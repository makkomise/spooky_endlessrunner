using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour
{
    public float gravity = 20.0f;
    public float jumpHeight = 2.5f;
    public float movementSpeed;

    Rigidbody rb;
    bool grounded = false;
    Vector3 defaultScale;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionZ;
        rb.freezeRotation = true;
        rb.useGravity = false;
        defaultScale = transform.localScale;
    }

    void Update()
    {
        // Hyppy

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, CalculateJumpVerticalSpeed(), rb.velocity.z);
            grounded = false;
        }

        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.5f, 1.5f), transform.position.y, 0);  //rajottaa sivuttaisliikkeen m‰‰r‰‰ ettei mee kent‰n "yli"
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        rb.AddForce(new Vector3(0, -gravity * rb.mass, 0));

        grounded = false;
    }

    void OnCollisionStay()
    {
        grounded = true;
    }

    float CalculateJumpVerticalSpeed()
    {
        // From the jump height and gravity we deduce the upwards speed 
        // for the character to reach at the apex.
        return Mathf.Sqrt(2 * jumpHeight * gravity);
    }
}