using UnityEngine;
using System.Collections;

public class RocketsSpawner : MonoBehaviour
{
    public Transform RocketsParent;
    public GameObject RocketPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRocket(RocketPrefab);
        }
    }

    public void SpawnRocket(GameObject prefab)
    {
        GameObject newRocket = Instantiate(prefab) as GameObject;
        newRocket.transform.SetParent(RocketsParent);
        newRocket.transform.position = transform.position;
        newRocket.transform.localEulerAngles = transform.localEulerAngles;
    }
}