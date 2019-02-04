using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        Debug.Log("on Load next scene");
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((sceneIndex + 1) % 3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
