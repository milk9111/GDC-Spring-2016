﻿using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;
    public float minSpawnTime;
    public float maxSpawnTime;
    public int enemyCount;
    //public Transform spawn;

	// Use this for initialization
	void Start () {
        StartCoroutine (Spawn());
        //InvokeRepeating("Spawn", spawnTime, Random.Range(2, 6));
	}
	
    IEnumerator Spawn () {
        yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            for (int i = enemyCount; i >= 0; i--) {
                Instantiate(enemy, transform.position, enemy.transform.rotation);
                yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            }   
    }
}