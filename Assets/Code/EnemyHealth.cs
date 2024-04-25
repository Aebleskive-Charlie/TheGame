using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float health = 100f;
    public healthbar healthbar;
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthbar.SetHealth(health);


        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }

}
