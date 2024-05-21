using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionSceneStarts : MonoBehaviour
{
    [SerializeField]
    private GameObject mission1Mark;
    [SerializeField]
    private GameObject mission2Mark;
    [SerializeField]
    private GameObject mission3Mark;

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.instance.mission1Completed == true)
        {
            mission1Mark.SetActive(true);
        }
        if (GameManager.instance.mission2Completed == true)
        {
            mission2Mark.SetActive(true);
        }
        if (GameManager.instance.mission3Completed == true)
        {
            mission3Mark.SetActive(true);
        }
        if (GameManager.instance.mission1Completed == true && GameManager.instance.mission2Completed == true && GameManager.instance.mission3Completed == true)
        {
            SceneManager.LoadScene("FinishScene");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
