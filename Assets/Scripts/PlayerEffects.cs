using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerEffects : MonoBehaviour
{
    [SerializeField] private SpriteRenderer effect1;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            effect1.color = new Color(effect1.color.r, effect1.color.g, effect1.color.b, 1);
        }
        else
        {
            effect1.color = new Color(effect1.color.r, effect1.color.g, effect1.color.b, 0);
        }
    }
}