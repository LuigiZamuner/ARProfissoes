using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionsButton : MonoBehaviour
{

    [SerializeField] private string scene;


    public void ChangeScene()
    {
        SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
    }
    public void UnloadScene()
    {
        SceneManager.UnloadSceneAsync(scene);
    }
    public void ChangeScene2()
    {
        SceneManager.LoadScene(scene);
    }
}
