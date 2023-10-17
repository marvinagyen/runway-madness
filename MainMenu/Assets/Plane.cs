using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Plane : MonoBehaviour
{
    public int color = 0;
    public List<Sprite> plane_sprites = new List<Sprite>();
    // new stuff
    public GameObject gameHandler;
    // public GameObject gameOverScreen;

    void Awake() {
        gameHandler = GameObject.FindWithTag("gamehandler");
        // new stuff
        // Debug.Log("test if it's being set to false");
        // gameOverScreen.SetActive(false);
    }

    public void ChangeColor(int newColor)
    {
        color = newColor;
        this.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = plane_sprites[color];
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fuelPump") && color == 2) {
            ChangeColor(3);
        }
        else if (collision.gameObject.CompareTag("terminal") && ((color == 3) || (color == 1)))
        {
            gameHandler.transform.GetComponent<ScoreTracker>().AddScore(1);
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("garage") && color == 0) 
            ChangeColor(3);
        else if (collision.gameObject.CompareTag("Plane"))
        {
            gameHandler.transform.GetComponent<ScoreTracker>().EndGame();
            // new stuff
            // gameOverScreen.SetActive(true);  
        }
    }

    }
    
