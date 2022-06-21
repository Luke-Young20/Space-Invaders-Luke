using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] float rowCount = 12;
    [SerializeField] float columnCount = 12;
    float xSpawnStart = -8;
    float ySpawnStart = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
        //InvokeRepeating("SpawnEnemies", 0, 1);
    }

    private void SpawnEnemies()
    {
        SpawnEnemy();


    }

    public void SpawnEnemy()

    {
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {

                Vector2 location = new Vector2(xSpawnStart + i, ySpawnStart + j);
                GameObject Enemy = Instantiate(Resources.Load("Enemy"), location, Quaternion.identity, this.transform) as GameObject;

            }
        }
    }
}
