using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public CanvasGroup CanvasGroup;
    public Vector2 Vector2;
    public Vector2 OriginalVector2;
    public bool moved = false;
    private void Start()
    {
        CanvasGroup = GetComponent<CanvasGroup>();
        OriginalVector2 = GetComponent<RectTransform>().anchoredPosition;
    }
    void Update()
    {

    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position += (Vector3)eventData.delta;
        Vector2 = GetComponent<RectTransform>().anchoredPosition;

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        moved = true;
        CanvasGroup.alpha = .5f;
        CanvasGroup.blocksRaycasts = false;  
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (GetComponent<RectTransform>().anchoredPosition == Vector2)
        {
            GetComponent<RectTransform>().anchoredPosition = OriginalVector2;
            moved = false;
            //
        }
        CanvasGroup.alpha = 1f;
        CanvasGroup.blocksRaycasts = true;

    }


}