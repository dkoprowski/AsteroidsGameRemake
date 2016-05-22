using UnityEngine;
using System.Collections;

public class BlinkBehav : MonoBehaviour
{
    public Collider2D colliderToCheck;
    public SpriteRenderer spriteToBlink;
    public float blinkCycleTime;
    private float nextBlink;
    private void Start()
    {
        
    }
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
        spriteToBlink.color = new Color(spriteToBlink.color.r, spriteToBlink.color.g, spriteToBlink.color.b, 1f - spriteToBlink.color.a);
    }
}
