using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IShootable
{
    Rigidbody2D rb;
    float enemyMovementSpeed;
    void Start()
    {
        enemyMovementSpeed = 2f;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1, 0) * enemyMovementSpeed;

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
}
