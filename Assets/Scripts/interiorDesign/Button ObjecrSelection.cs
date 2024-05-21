using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonObjecrSelection : MonoBehaviour
{
    [SerializeField]
    private int index;

    public void OnClick()
    {
        DesignPlaceObject.indexRequest?.Invoke(index);
    }
}
