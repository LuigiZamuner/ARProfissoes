using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class DesignPlaceObject : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> objects = new List<GameObject>();

    private ARPlacementInteractable interactable;
    
    public static Action<int> indexRequest;


    private void Awake()
    {
        interactable = GetComponent<ARPlacementInteractable>();
    }

    private void OnEnable()
    {
        indexRequest += ObjectSelector;
    }

    private void OnDisable()
    {
        indexRequest -= ObjectSelector;
    }

    public void ObjectSelector(int index)
    {
        interactable.placementPrefab = objects[index];
    }
}
