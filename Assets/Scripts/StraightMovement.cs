using UnityEngine;
using System.Collections;

public class StraightMovement : MonoBehaviour {
    public float MovementSpeed;
    public float OutOfBoundsDistance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MoveForward(MovementSpeed);

        if (Vector3.Distance(transform.position, Vector3.zero) > OutOfBoundsDistance)
            Destroy(gameObject);
	}

    void MoveForward(float speed)
    {
        gameObject.transform.localPosition += transform.up * speed * Time.deltaTime;
    }
}
