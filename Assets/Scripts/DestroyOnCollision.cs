using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour
{
    private PointsController pointsController;
    private GameObject explosionPrefab;
    private GameObject explosionsParent;

    private void Start()
    {
        pointsController = FindObjectOfType<PointsController>();
        explosionsParent = GameObject.Find("ExplosionsParent");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
            Destroy(collision.gameObject);

        var explosion = Instantiate(explosionPrefab) as GameObject;
        explosion.transform.SetParent(explosionsParent.transform);
        explosion.transform.localPosition = new Vector3(gameObject.transform.localPosition.x,
            gameObject.transform.localPosition.y, explosion.transform.localPosition.z);

        Destroy(gameObject);
        pointsController.AddPoint();
    }
}