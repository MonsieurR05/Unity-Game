using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed = 500.0f;
    public float lifeTime = 10.0f;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
    }

    public void Shoot(Vector2 direction)
    {
        rb2d.AddForce(direction * speed );
        Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
