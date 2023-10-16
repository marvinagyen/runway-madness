using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scoreText;
    private int playerScore = 0;

    void Start(){
          UpdateScore();
    }

    public void AddScore(int points){
          playerScore += points;
          UpdateScore();
    }

    void UpdateScore(){
          Text scoreTextB = scoreText.GetComponent<Text>();
          scoreTextB.text = "" + playerScore;
    }
}
