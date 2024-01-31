using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 10);
        rb.angularVelocity = 100;
    }
    private void Update()
    {
        if(transform.position.y < -5)
        {
            Die();
        }
    }
    public void Die()
    {

    }
}
