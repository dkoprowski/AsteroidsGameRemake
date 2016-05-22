using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour
{
    public PointsController pointsController;

    public void Start()
    {
        pointsController = FindObjectOfType<PointsController>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
            Destroy(collision.gameObject);
        Destroy(gameObject);
        pointsController.AddPoint();
    }
}
