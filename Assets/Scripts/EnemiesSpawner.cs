using UnityEngine;
using System.Collections;
using System;

public class EnemiesSpawner : MonoBehaviour {
   
    public float DirectionUpperLimit;
    public float DirectionBottomLimit;
    public GameObject EnemyPrefab;
    public Transform EnemiesParent;
    public float SpawnFrequency;
    private float nextSpawn;
    private UnityEngine.Random rand = new UnityEngine.Random();
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawn)
        {

            CreateEnemy(EnemyPrefab);

            nextSpawn += SpawnFrequency;
        }
    }

    private void CreateEnemy(GameObject EnemyPrefab)
    {
        GameObject newEnemy = Instantiate(EnemyPrefab) as GameObject;
        newEnemy.transform.SetParent(EnemiesParent);
        newEnemy.transform.position = transform.position;
        newEnemy.transform.localEulerAngles = new Vector3(0,0,UnityEngine.Random.Range(DirectionBottomLimit, DirectionUpperLimit));
    }
}
