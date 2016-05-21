using UnityEngine;
using System.Collections;

public class PlayerBehav : MonoBehaviour {

    public PointsController points;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        points.RemoveLife();
    }
}
