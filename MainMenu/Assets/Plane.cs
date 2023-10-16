using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Vector3 startMarker = Vector3.zero;
    public Vector3 endMarker = Vector3.zero;
    public float speed = 1.0f;
    private float startTime;
    private float journeyLength;
    private bool moving = false;


    public int color = 0;
    public List<Sprite> plane_sprites = new List<Sprite>();

    public void ChangeColor(int newColor)
    {
        color = newColor;
        this.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = plane_sprites[color];
    }

    public void MovePlane(Vector3 destination)
    {
        startMarker = transform.position;
        moving = true;
        startTime = Time.time;
        endMarker = destination;
        journeyLength = Vector3.Distance(startMarker, endMarker);
    }





    void Update()
    {
        if (moving)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker, endMarker, fractionOfJourney);

            if (transform.position == endMarker)
            {
                moving = false;
            }
        }

    }
}
