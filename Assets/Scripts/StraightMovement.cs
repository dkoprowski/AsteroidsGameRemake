using UnityEngine;
using System.Collections;

public class StraightMovement : MonoBehaviour {
    public float MovementSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MoveForward(MovementSpeed);
	}

    void MoveForward(float speed)
    {
        gameObject.transform.localPosition += transform.up * speed * Time.deltaTime;
    }
}
