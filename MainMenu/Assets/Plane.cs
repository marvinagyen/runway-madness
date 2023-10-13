using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public int color = 0; 
    public List<Sprite> plane_sprites = new List<Sprite>();
    Transform art;

    public void ChangeColor(int newColor)
    {
        color = newColor;
        art.GetComponent<SpriteRenderer>().sprite = plane_sprites[color];
    }
}
