using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    float bulletMovementSpeed = -75f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletMovementSpeed);
    }

    private void Update()
    {
        IsOffscreen();
    }
    private void IsOffscreen()
    {
        //min values are like 15/-15 and 10/-10
        if (transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Destroy(this.gameObject);
        }


    }
}
