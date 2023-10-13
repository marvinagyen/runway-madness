using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] GameObject menuUI;
    public static bool GameIsPaused;
    
    void Start()
    {
        Resume();
    }
    
    void Update()
    {
        if(Input.GetKeyDown("escape")) {
            if(GameIsPaused) {Resume();}
            else {Pause();}
        }
    }
    // Start is called before the first frame update
    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        menuUI.SetActive(true);
    }
    
    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        menuUI.SetActive(false);
    }
    
    public void Quit()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
