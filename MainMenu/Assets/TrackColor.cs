using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
    /*array to hold the coloured planes, a timer and keep track of the curr
    coloured plane*/
    public GameObject planePrefab;
//   public GameObject[] planes;
//   public float planeTimer = 0f;
//   public int color = -1;

//   void Start()
//   {
//     /* making all planes invisible*/
//     for each (GameObject planes in planes) {
//         planes[color].setActive(false);
//     } 
//     planeTimer = 30f;
//   }

//   void Update()
//   {
//     planeTimer -= Time.deltaTime;
//     if (planeTimer <= 0f){
//         planeTimer = 30f;

//         /* making the current colored plane invisible */
//         if (color >= 0 && color < planes.length){
//             planes[color].setActive(false);
//         }

//         int randomizeColor;
//         do 
//         {
//             randomizeColor = Random.Range(0, planes.length);
//         } while (randomizeColor == color);

//         color = randomizeColor;
//         planes[color].setActive(true);

//     }

//   }

}
