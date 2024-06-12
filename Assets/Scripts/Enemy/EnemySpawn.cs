using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform[] spawnLocations;
    public int spawnTime;
    public PlayerHealth playerHealth;
    public GameObject enemy;
    //public GameObject player;
    PlayerPlatform platform;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
    }

    void SpawnEnemy()
    {
        if (playerHealth.currentHealthplayer <= 0)
        {
            return;
        }
        else
        {
            int index = Random.Range(0, spawnLocations.Length);
            Instantiate(enemy, spawnLocations[index].position, transform.rotation);
        }
    }
}
