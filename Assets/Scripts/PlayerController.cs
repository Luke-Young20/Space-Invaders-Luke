using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private Transform BulletSpawnPoint;
    [SerializeField] private float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(h, 0) * movementSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bullet = Instantiate(Resources.Load("Bullet"), BulletSpawnPoint.transform.position, transform.rotation) as GameObject;



        }
    }
}
