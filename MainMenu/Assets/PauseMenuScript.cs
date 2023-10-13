using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void PauseGame()
    {
        SceneManager.LoadSceneAsync(4);
    }
}
