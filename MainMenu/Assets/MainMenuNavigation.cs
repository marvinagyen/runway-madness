using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigation : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(4);
    }
    
    public void GoToInstructions()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
