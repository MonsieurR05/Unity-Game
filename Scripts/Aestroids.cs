using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Aestroids : MonoBehaviour
{
    public float xSpeed = 50f;
    public float ySpeed = 50f;
    public int ScoreValue = 10;
    public GameObject explosion;



    Rigidbody2D rb2d;
    public GameObject TopArea;
    public GameObject BottomArea;
    // Start is called before the first frame update
    void Start()
    {
        SetStartPosition(); rb2d = GetComponent<Rigidbody2D>();
        float random = Random.Range(20f, 100f);
        Vector2 force = new Vector2(xSpeed * random, ySpeed * random);
        rb2d.AddForce(force);
    }     // Update is called once per frame
    void Update()
    {
    }
    void SetStartPosition()
    {
        Vector2 topLeft = TopArea.transform.position;
        Vector2 bottomRight = BottomArea.transform.position; float randomX = Random.Range(topLeft.x, bottomRight.x);
        float randomY = Random.Range(topLeft.y, bottomRight.y); Vector2 startingPosition = new Vector2(randomX, randomY);
        transform.position = startingPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            ScoreManager.instance.AddPoint(ScoreValue);

        }
    }
}