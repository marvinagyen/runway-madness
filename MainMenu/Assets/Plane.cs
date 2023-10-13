using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Transform startMarker;
    public Transform endMarker;
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
        moving = true;
        startTime = Time.time;
        endMarker.position = destination;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }





    void Update()
    {
        if (moving)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);

            if (transform.position == endMarker.position)
            {
                moving = false;
            }
        }

    }
}
