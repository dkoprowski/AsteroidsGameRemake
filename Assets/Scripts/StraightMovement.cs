using UnityEngine;
using System.Collections;

public class StraightMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float OutOfBoundsDistance;

    private void Update()
    {
        MoveForward(MovementSpeed);

        if (Vector3.Distance(transform.position, Vector3.zero) > OutOfBoundsDistance)
            Destroy(gameObject);
    }

    private void MoveForward(float speed)
    {
        gameObject.transform.localPosition += transform.up * speed * Time.deltaTime;
    }
}