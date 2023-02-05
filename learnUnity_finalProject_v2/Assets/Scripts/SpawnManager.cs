using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;

    private float zEnemySpawn = 90;
    private float xEnemySpawnRange = 78;
    private float ySpawn = 14;

    private float startDelay = 3;

    public float spawnRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnRate);
    }


    void SpawnRandomEnemy()
    {

        float randomX = Random.Range(-xEnemySpawnRange, xEnemySpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);


    }
}
