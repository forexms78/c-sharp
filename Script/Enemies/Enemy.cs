using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
   
        float health = 50.0f;

    public float Health
    {
        get { return health; }
    }

    private void Start()
    {
        Debug.Log("health : " + health);
    }

    void TakeDamage(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }
    }

        public float GetGealth()
        {
            return health;
        }

        void Die()
        {
            Destroy(this.gameObject);
        }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamage(10);
        Debug.Log("health : " + health);
        collision.gameObject.SetActive(false);
    }

}
