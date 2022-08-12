using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IShootable
{
    [SerializeField] private Transform EnemyBulletSpawnPoint;
    Rigidbody2D rb;
    public float dirX;
    public bool facingRight = false;
    private Vector3 localScale;
    float enemyMovementSpeed;

    void Start()
    {
        localScale = transform.localScale;
        
        rb = GetComponent<Rigidbody2D>();
       // rb.velocity = new Vector2(1, 0) * enemyMovementSpeed;
        dirX = -1f;
        enemyMovementSpeed = 2f;
        InvokeRepeating("Shoot", 0, Random.Range(3,20));
    }

    public void Shot()
    {
        Die();
    }
    public void Die()
    {
        ScoreManager.updateScore();
        Destroy(this.gameObject);
    }
    public void Shoot() {
       GameObject Bullet = Instantiate(Resources.Load("EnemyBullet"), EnemyBulletSpawnPoint.transform.position, transform.rotation) as GameObject;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Wall>()) {
            dirX *= -1f;
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * enemyMovementSpeed, rb.velocity.y);
    }
    void LateUpdate() {
        CheckWhichWayToFace();
    }

    void CheckWhichWayToFace()
    {
        if (dirX > 0)
            facingRight = true;
        else if (dirX < 0)
            facingRight = false;

        if (((facingRight) && (localScale.x < 0)) || (!facingRight) && (localScale.x > 0))
                localScale.x *= -1;
        transform.localScale = localScale;
    }
}
