using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsNavigation : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReturnHome()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
