using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collision : MonoBehaviour {

     /*Renderer rend;
    bool addColor;
 

     void Start()
    {
        rend = GetComponent<Renderer>();
        gameObject.GetComponent<Renderer>().material.color -= new Color(0,0,0,0.1f);
    }

    void updateChangeColor()
    {
        if (rend.material.color.a >= 1)
        {
            addColor = false;
        }

        else if (rend.material.color.a <= 0)
        {
            addColor = true;
        }

        if (addColor)
        {
            rend.material.color += new Color(0, 0, 0, 0.05f);
        }

        else
        {
            rend.material.color -= new Color(0, 0, 0, 0.05f);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        updateChangeColor();
    }*/


    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Trigger Enter: " + collision.gameObject.CompareTag("Player"));
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            renderer.color = new Color(255f, 255f, 255f);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Trigger Exit: " + collision.gameObject.CompareTag("Player"));
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            renderer.color = new Color(139f, 0f, 0f);
        }
    }*/

    void OnCollisionEnter2D(Collision2D collision)
        {
           //gameObject.transform.Translate(Vector2.left);
           transform.localScale += new Vector3(1, 1, 1);
        }

    //void OnCollisionStay2D(Collision2D collision)
    //{
    //    transform.localScale += new Vector3(1, 1, 1);
    //}

    //void OnTriggerStay2D(Collider2D collision)
    //{
    //    gameObject.transform.Rotate(new Vector2(6, 4));
    //}

}