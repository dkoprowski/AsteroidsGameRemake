using UnityEngine;
using System.Collections;

public class RocketBehaviour : MonoBehaviour
{
    public PointsController points;

    public void Start()
    {
        points = FindObjectOfType<PointsController>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        points.AddPoint();
    }
}
