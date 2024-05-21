using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiategameobjec : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {

        if (gameObject.CompareTag("ArObject"))
        {
            GameManager.instance.mission3count++;
            if (GameManager.instance.mission3count >= 5)
            {
                GameManager.instance.mission3Completed = true;
            }
        }
        if (gameObject.CompareTag("Table"))
        {
            GameManager.instance.mission3count++;
            GameManager.instance.mission1Completed = true;
        }
        if (gameObject.CompareTag("chair"))
        {
            GameManager.instance.mission3count++;
            GameManager.instance.mission2count++;
            if (GameManager.instance.mission2count >= 2)
            {
                GameManager.instance.mission2Completed = true;
            }
        }
    }

}
