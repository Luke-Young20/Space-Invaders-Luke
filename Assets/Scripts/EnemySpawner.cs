using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 0, 1);
    }

    private void SpawnEnemies()
    {
        SpawnEnemy();


    }

    public void SpawnEnemy()

    {
        Vector2 location = new Vector2(-8,1.5f);
        GameObject Enemy = Instantiate(Resources.Load("Enemy"), location, Quaternion.identity, this.transform) as GameObject;

    }
}
