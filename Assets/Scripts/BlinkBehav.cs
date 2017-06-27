using UnityEngine;
using System.Collections;

public class BlinkBehav : MonoBehaviour
{
    [SerializeField] private Collider2D colliderToCheck;
    [SerializeField] private SpriteRenderer spriteToBlink;
    [SerializeField] private float blinkCycleTime;
    private float nextBlink;

    private void Update()
    {
        if (!colliderToCheck.enabled)
        {
            if (Time.time > nextBlink)
            {
                Blink();
                nextBlink = (Time.time + blinkCycleTime);
            }
        }
        else
        {
            if (spriteToBlink.color.a < 1f)
            {
                spriteToBlink.color = new Color(spriteToBlink.color.r, spriteToBlink.color.g, spriteToBlink.color.b, 1f);
            }
        }
    }

    private void Blink()
    {
        spriteToBlink.color = new Color(spriteToBlink.color.r, spriteToBlink.color.g, spriteToBlink.color.b,
            1f - spriteToBlink.color.a);
    }
}