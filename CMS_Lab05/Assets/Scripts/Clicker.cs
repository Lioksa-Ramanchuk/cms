using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Clicker : MonoBehaviour, IPointerClickHandler
{
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        Vector3 pointA = eventData.pointerPressRaycast.worldPosition;
        Vector3 pointB = Camera.main.transform.position;
        Vector3 direction = (pointA - pointB).normalized;
        Vector3 force = direction * 500;
        Vector3 target = eventData.pointerCurrentRaycast.worldPosition;
        gameObject.GetComponent<Rigidbody>().AddForceAtPosition(force, target);
    }
}