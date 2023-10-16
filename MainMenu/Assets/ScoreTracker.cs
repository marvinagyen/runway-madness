using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTracker : MonoBehaviour {
      public TextMeshProUGUI scoreText;
      public static int playerScore = 0;
      [SerializeField] public GameObject endMenu;
      
      void Start() {
            UpdateScore();
      }
      
      public void AddScore(int points){
            playerScore += points;
            UpdateScore();
      }
      
      public void UpdateScore(){
            scoreText.text = "Score: " + playerScore;
      }
      
      public void EndGame() {
          endMenu.SetActive(true);
          Time.timeScale = 0f;
      }

      // public GameObject scoreText;
      // private int playerScore = 0;
      // 
      // void Start(){
      //       UpdateScore();
      // }
      // 
      // public void AddScore(int points){
      //       playerScore += points;
      //       UpdateScore();
      // }
      // 
      // void UpdateScore(){
      //       Text scoreTextB = scoreText.GetComponent<Text>();
      //       scoreTextB.text = "SCORE: " + playerScore;
      // }
}
