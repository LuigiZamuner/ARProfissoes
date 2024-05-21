using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static Action<string> RequestSceneLoad;

    private void OnEnable()
    {
        RequestSceneLoad += LoadScene;
    }

    private void OnDisable()
    {
        RequestSceneLoad -= LoadScene;
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }


}
