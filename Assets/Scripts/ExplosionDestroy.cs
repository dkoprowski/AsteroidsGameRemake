using UnityEngine;
using System.Collections;

public class ExplosionDestroy : MonoBehaviour {

    public float LifeTime = 2f;
    private float CreateTime;

	void Start () {
        CreateTime = Time.time;
	}
	
	void Update () {
        if (Time.time > CreateTime + LifeTime)
            Destroy(gameObject);
	}
}
