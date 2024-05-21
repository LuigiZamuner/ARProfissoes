
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using ETouch = UnityEngine.InputSystem.EnhancedTouch;

public class MissionSupport : MonoBehaviour
{
    private int objectCount = 0;
    private int chairCount = 0;
    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();

        ETouch.Touch.onFingerDown += HandleFingerDown;
    }

    private void OnDisable()
    {
        EnhancedTouchSupport.Disable();

        ETouch.Touch.onFingerDown -= HandleFingerDown;
    }

    private void HandleFingerDown(Finger finger)
    {
        GameObject[] objectsInScene = GameObject.FindGameObjectsWithTag("Movel");

        Debug.Log(objectsInScene);
        foreach (GameObject obj in objectsInScene)
        {
            if (obj.transform.parent.CompareTag("ArObject"))
            {
                objectCount++;
                if (objectCount == 5)
                {
                    GameManager.instance.mission3Completed = true;
                }
            }
            else if (obj.transform.parent.CompareTag("Table"))
            {

                    GameManager.instance.mission1Completed = true;
            }
            else if (obj.transform.parent.CompareTag("Chair"))
            {
                chairCount++;
                if (chairCount == 2)
                {
                    GameManager.instance.mission2Completed = true;
                }
            }
        }

        // Resetar os contadores, independentemente do resultado
        objectCount = 0;
        chairCount = 0;

    }

}