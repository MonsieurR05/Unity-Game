using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    private Vector2 movement;
    private Rigidbody2D rb2d;
    public Transform Player;
    public float moveSpeed = 5f;
    public int ScoreValue = 100;
    public GameObject blood;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb2d.rotation = angle;
        direction.Normalize();
        movement = direction;

  
    }
    private void FixedUpdate()
    {
        moveEnemy(movement);
    }
    void moveEnemy(Vector2 direction)
    {
        rb2d.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            ScoreManager.instance.AddPoint(ScoreValue);
            Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(gameObject);


        }
    }
}
