using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [SerializeField] private float damage = 10f;



    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            playerHealth PlayerHealth = other.gameObject.GetComponent<playerHealth>();
            PlayerHealth.TakeDamage(damage);

        }
        Destroy(gameObject);
    }
}
