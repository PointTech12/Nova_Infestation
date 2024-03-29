using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 400;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            
        }
        //Destory Bullet After collison ??
        Destroy(gameObject);
  
    }
    void Delete()
    {
        // Destroy the enemy GameObject after the death animation is complete
        Destroy(gameObject);
    }

}