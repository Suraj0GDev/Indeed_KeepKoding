using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //For any button to change Scene
    public void sceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
