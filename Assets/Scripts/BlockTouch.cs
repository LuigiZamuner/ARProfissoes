using UnityEngine;
using UnityEngine.EventSystems;

public class BlockTouch : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        eventData.Use(); // Bloqueia a propaga��o do toque
    }
}