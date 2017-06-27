using UnityEngine;
using System.Collections;

public enum Direction
{
    LEFT,
    RIGHT
}

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    private Rigidbody2D _rigidbody;
    private Camera _camera;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _camera = FindObjectOfType<Camera>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            Rotate(Direction.LEFT);
        else if (Input.GetKey(KeyCode.RightArrow))
            Rotate(Direction.RIGHT);

        if (Input.GetKey(KeyCode.UpArrow))
            MoveForward(MovementSpeed);

        CheckPlayerPosition();
    }

    void Rotate(Direction direction)
    {
        var currentRotation = gameObject.transform.localEulerAngles.z;
        if (direction == Direction.LEFT)
            gameObject.transform.localEulerAngles = new Vector3(0, 0,
                currentRotation + (1 * RotationSpeed * Time.deltaTime));
        else
            gameObject.transform.localEulerAngles = new Vector3(0, 0,
                currentRotation - (1 * RotationSpeed * Time.deltaTime));
    }

    void MoveForward(float speed)
    {
        _rigidbody.AddForce(transform.up * speed, ForceMode2D.Force);
    }

    void CheckPlayerPosition()
    {
        var extents = OrthographicExtents(_camera);

        if (transform.localPosition.y > extents.y)
            transform.localPosition = new Vector3(transform.localPosition.x, -extents.y, 0);

        if (transform.localPosition.y < -extents.y)
            transform.localPosition = new Vector3(transform.localPosition.x, extents.y, 0);

        if (transform.localPosition.x > extents.x)
            transform.localPosition = new Vector3(-extents.x, transform.localPosition.y, 0);

        if (transform.localPosition.x < -extents.x)
            transform.localPosition = new Vector3(extents.x, transform.localPosition.y, 0);
    }

    private Vector2 OrthographicExtents(Camera camera)
    {
        float height = 2f * camera.orthographicSize;
        float width = height * camera.aspect;

        return new Vector2(width / 2f, height / 2f);
    }
}