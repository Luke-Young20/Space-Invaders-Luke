using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float bulletMovementSpeed = 500f;
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
        if (transform.position.y > 15)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out IShootable hit))
        {
            hit.Shot();
            Destroy(this.gameObject);

        }

    }
}

