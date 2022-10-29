using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer sprite;
    [HideInInspector] public System.Single R { get; set; } = 1; 
    [HideInInspector] public System.Single G { get; set; } = 1;
    [HideInInspector] public System.Single B { get; set; } = 1;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void UpdateSprite()
    {
        Color c = new Color(R, G, B, 1);
        sprite.color = c;
    }
}
