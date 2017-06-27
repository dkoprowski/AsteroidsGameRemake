using UnityEngine;
using System.Collections;

public class ExplosionDestroy : MonoBehaviour {

    public float LifeTime = 2f;
    private float createTime;

	void Start () {
        createTime = Time.time;
	}
	
	void Update () {
        if (Time.time > createTime + LifeTime)
            Destroy(gameObject);
	}
}
