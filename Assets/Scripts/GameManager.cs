using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int mission2count = 0;
    public int mission3count = 0;

    public bool mission1Completed = false;
    public bool mission2Completed = false;
    public bool mission3Completed = false;

    public static GameManager instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;


        DontDestroyOnLoad(gameObject);
    }

}
