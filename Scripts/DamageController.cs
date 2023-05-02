using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    public int EnemyDamage;
    public GameObject panel;

    public HeartSystem healthController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Damage();
        }
        if (healthController.playerHealth < 1)
        {
            Destroy(collision.gameObject);
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - EnemyDamage;
        healthController.UpdateHealth();
    }
}
