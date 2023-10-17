using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawn : MonoBehaviour
{
    public GameObject planePrefab;
    public float planeTimer = 5f;
    public int color;
    public int random;
    public Transform planeGroup;

    public Transform[] spawnPoints;

  void Update()
  {
    planeTimer -= Time.deltaTime;
    if (planeTimer <= 0f){
        int score = (ScoreTracker.playerScore <= 0 ? 1 : ScoreTracker.playerScore);
        planeTimer = 15/score + 2;

        color = Random.Range(0,3);
        random = Random.Range(0,3);
        GameObject newPlane = Instantiate(planePrefab, spawnPoints[random].position, Quaternion.identity, planeGroup) as GameObject;
        newPlane.GetComponent<Plane>().ChangeColor(color);


        // /* making the current colored plane invisible */
        // if (color >= 0 && color < planes.length){
        //     planes[color].setActive(false);
        // }

        // int randomizeColor;
        // do 
        // {
        //     randomizeColor = Random.Range(0, planes.length);
        // } while (randomizeColor == color);

        // color = randomizeColor;
        // planes[color].setActive(true);

    }

  }
}
