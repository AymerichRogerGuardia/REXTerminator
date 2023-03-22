using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 1.0f;
    public float spawnDistance = 15.0f;
    public int spawnAmount = 1;
    public float lastSpawn = 0;

    private void Start()
    {

    }
    private void Update()
    {
        if (Time.time > spawnRate + lastSpawn)
        {
            Spawn();
            lastSpawn = Time.time;
        } 
        spawnRate += Time.deltaTime / (-40);
    }
        
       

    private void Spawn()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            Quaternion rotation = Quaternion.AngleAxis(0, Vector3.forward);

            GameObject enemy = Instantiate(this.enemyPrefab, transform.position, rotation);
        }
    }

    
}