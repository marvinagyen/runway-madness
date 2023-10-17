using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI; 

public class Timer : MonoBehaviour
{

public GameObject timeText;
// public GameObject gameOverText;
public int gameTime = 420;
private float gameTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // gameOverText.SetActive(false);
        UpdateTime(); 
    }

    // Update is called once per frame
    void Update()
    {
         gameTimer += 0.01f;
            if (gameTimer >= 1f){
                        gameTime -= 1;
                        gameTimer = 0;
                        UpdateTime();
            }
            if (gameTime <= 0){
                        gameTime = 0;
                        // gameOverText.SetActive(true);
            }
    }

    public void UpdateTime(){
            Text timeTextB = timeText.GetComponent<Text>();
            timeTextB.text = "Time: " + gameTime;
      }
}
