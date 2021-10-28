using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour
{
    public float gravity = 20.0f;
    public float jumpHeight = 2.5f;
    public float movementSpeed;
    public PlayerLight playerLight;

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
       
        if (Input.GetKeyDown(KeyCode.Space) && grounded) //hyppy
        {
            rb.velocity = new Vector3(rb.velocity.x, CalculateJumpVerticalSpeed(), rb.velocity.z);
            grounded = false;
        }

        if (Input.GetKey("left") || Input.GetKey("a")) //vasen
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey("right") || Input.GetKey("d")) //oikee
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKeyUp(KeyCode.Escape)) //takas valikkoon
        {
            SceneManager.LoadScene("MainMenu");
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

    float CalculateJumpVerticalSpeed()  //hyppylaskutoimitus
    {
        return Mathf.Sqrt(2 * jumpHeight * gravity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Table"))   //osu pˆyt‰‰n, kuole
        {
            Die();
        }        
    }

    private void OnTriggerEnter(Collider collision) //kun pelaaja osuu kynttil‰‰n, kasvatetaan lampun kirkkautta
    {
        if (collision.gameObject.CompareTag("Candle"))
        {
            playerLight.IncreaseIntensity();
        }
    }

    public void Die()   //pit‰‰ks t‰‰ ny selitt‰‰ eriksee?
    {
        SceneManager.LoadScene("GameOver");
    }
}