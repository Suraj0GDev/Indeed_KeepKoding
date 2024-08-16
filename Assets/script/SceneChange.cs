using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Method to change the scene
    public void sceneChange(string sceneName)
    {
        // Loads the scene with the given name
        SceneManager.LoadScene(sceneName);
    }
}
