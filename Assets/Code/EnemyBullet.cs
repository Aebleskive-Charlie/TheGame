using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float cooldownTime = 1f;
    public float bulletSpeed = 30f;
    private float lastUsedTime;

    public Rigidbody bullet;
    void Update()
    {
        if (Time.time > lastUsedTime + cooldownTime)
        {
            Rigidbody clonnedRocket;
            clonnedRocket = Instantiate(bullet, transform.position, transform.rotation);

            clonnedRocket.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);

            lastUsedTime = Time.time;
        }
    }
}
