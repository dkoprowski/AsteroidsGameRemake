﻿using UnityEngine;
using System.Collections;

public class RocketBehaviour : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
