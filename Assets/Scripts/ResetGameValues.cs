using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameValues : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.mission1Completed = false;
        GameManager.instance.mission2Completed = false;
        GameManager.instance.mission3Completed = false;
    }

}
