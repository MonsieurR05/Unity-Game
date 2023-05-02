using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;


public class Test : MonoBehaviour
{
    public Bullet bulletPrefab;

    Rigidbody2D rb2d;
    public float thrustSpeed;
    public float turnSpeed;
    private float boostTimer;
    private bool boosting;
    public int ScoreValue = 5;

    //public float fireRate = 0.3f;
    //private float lastShot;


    // Start is called before the first frame update
    void Start()
    {
        thrustSpeed = 150;
        boostTimer = 0;
        boosting = false;

        Debug.Log("Hello World");
        Debug.Log(123);
        Debug.Log(gameObject.name);
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            shoot();
        }
        

        if (boosting)
        {
            boostTimer += Time.deltaTime; 
            if (boostTimer >= 10)
            {
                thrustSpeed = 150;
                boostTimer = 0;
                boosting = false;
                Debug.Log(boostTimer);
            }
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "speedBoost")
        {
            boosting = true;
            thrustSpeed = 250;
            Destroy(other.gameObject);
        }

        if (other.tag == "MyGem")
        {
            ScoreManager.instance.AddPoint(ScoreValue);
            Destroy(other.gameObject);
        }
    }

   
   


    void FixedUpdate()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector2 thrust = new Vector2(0, inputY * thrustSpeed);

        float rotate = -inputX * turnSpeed;

        rb2d.AddTorque(rotate);

        rb2d.AddRelativeForce(thrust);
    }

    private void shoot()
    {
        Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.Shoot(transform.up);
    }
}