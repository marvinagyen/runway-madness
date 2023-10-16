using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenuScript : MonoBehaviour
{
    public void Resume()
    {
        SceneManager.LoadSceneAsync(4);
    }
    
    public void Quit()
    {
        SceneManager.LoadSceneAsync(0);
    }
    
    public void PauseGame()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
