using UnityEngine;
using System.Collections;

public class RocketMovement : MonoBehaviour {
    public float RocketSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MoveForward(RocketSpeed);
	}

    void MoveForward(float speed)
    {
        gameObject.transform.localPosition += transform.up * speed * Time.deltaTime;
    }
}
