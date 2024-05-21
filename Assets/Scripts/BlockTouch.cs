using UnityEngine;
using UnityEngine.EventSystems;

public class BlockTouch : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        eventData.Use(); // Bloqueia a propagação do toque
    }
}