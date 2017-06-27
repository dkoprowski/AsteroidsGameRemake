using UnityEngine;
using System.Collections;

public class PlayerBehav : MonoBehaviour
{
    public PointsController points;
    public float PlayerRestTime;

    private Rigidbody2D _rigidbody2D;
    private Collider2D _collider2D;
    private float realRestTime;

    private void Awake()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        _collider2D = gameObject.GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (!_collider2D.enabled)
        {
            realRestTime += Time.deltaTime;
            if (realRestTime >= PlayerRestTime)
            {
                _collider2D.enabled = true;
            }
        }
        else
        {
            realRestTime = 0f;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        points.RemoveLife();
        RespawnPlayer();
    }

    private void RespawnPlayer()
    {
        transform.localPosition = new Vector3(0, 0, 0);
        transform.localEulerAngles = new Vector3(0, 0, 0);
        _rigidbody2D.velocity = new Vector2(0, 0);
        _rigidbody2D.angularVelocity = 0f;
        _collider2D.enabled = false;
    }

    public void DisablePlayer()
    {
        gameObject.SetActive(false);
    }
}