using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSceneChanger : MonoBehaviour
{
    [SerializeField] private string scene;
    

    public void ChangeScene()
    {
        SceneChanger.RequestSceneLoad?.Invoke(scene);
    }
}
