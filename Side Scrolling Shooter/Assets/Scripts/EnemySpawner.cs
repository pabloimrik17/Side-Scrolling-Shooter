using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemyToSpawn;

    public bool canSpawn = true;

    public float enemySpawnTime = 1.2f;
    public float maxSpawnY = 8.0f;
    public float startingX = 25.0f;

    float randomY = 0.0f;

	// Use this for initialization
	void Start () {
        StartCoroutine(enemySpawnTimer());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator enemySpawnTimer() {
        while(canSpawn) {
            spawnEnemy();
            yield return new WaitForSeconds(enemySpawnTime);
        }
    }

    void spawnEnemy() {
        randomY = Random.Range(-maxSpawnY, maxSpawnY);
        Instantiate(enemyToSpawn, new Vector3(startingX, randomY, 0), Quaternion.identity);
    }
}
