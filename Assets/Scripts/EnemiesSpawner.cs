using UnityEngine;
using System.Collections;
using System;

public class EnemiesSpawner : MonoBehaviour {
   
    public float DirectionUpperLimit;
    public float DirectionBottomLimit;
    public GameObject EnemyPrefab;
    public GameObject EnemyPrefab2;
    public GameObject EnemyPrefab3;
    public Transform EnemiesParent;
    public float SpawnFrequency;
    private float nextSpawn;
    private UnityEngine.Random rand = new UnityEngine.Random();
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawn)
        {

            CreateEnemy(RandomEnemy());

            nextSpawn = Time.time + SpawnFrequency;
        }

        if(SpawnFrequency > 1f)
            SpawnFrequency = SpawnFrequency - (Time.deltaTime * 0.03f);
    }

    private void CreateEnemy(GameObject EnemyPrefab)
    {

        GameObject newEnemy = Instantiate(EnemyPrefab) as GameObject;
        newEnemy.transform.SetParent(EnemiesParent);
        newEnemy.transform.position = transform.position;
        newEnemy.transform.localEulerAngles = new Vector3(0,0,UnityEngine.Random.Range(DirectionBottomLimit, DirectionUpperLimit));
    }

    private GameObject RandomEnemy()
    {
        float random = UnityEngine.Random.Range(0f, 1f);
        if (random > 0.8f)
            return EnemyPrefab3;
        else if (random > 0.5f)
            return EnemyPrefab2;
        else
            return EnemyPrefab;
    }
}
