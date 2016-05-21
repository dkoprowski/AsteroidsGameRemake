using UnityEngine;
using System.Collections;
public enum Direction
{
    LEFT,
    RIGHT
}
public class PlayerMovement : MonoBehaviour {

    public float MovementSpeed;
    public float RotationSpeed;
    private Rigidbody2D _rigidbody;
    // Use this for initialization
    void Start () {
        _rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
            Rotate(Direction.LEFT);
        else
        if (Input.GetKey(KeyCode.RightArrow))
            Rotate(Direction.RIGHT);

        if (Input.GetKey(KeyCode.UpArrow))
            MoveForward(MovementSpeed);
    }

    void Rotate(Direction direction)
    {
        var currentRotation = gameObject.transform.localEulerAngles.z;
        if (direction == Direction.LEFT)
            gameObject.transform.localEulerAngles = new Vector3(0, 0, currentRotation + (1 * RotationSpeed * Time.deltaTime));
        else
            gameObject.transform.localEulerAngles = new Vector3(0, 0, currentRotation - (1 * RotationSpeed * Time.deltaTime));

    }

    void MoveForward(float speed)
    {
        _rigidbody.AddForce(transform.up * speed, ForceMode2D.Force);
    }
}
