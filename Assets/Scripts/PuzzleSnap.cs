using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzleSnap : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    public bool isCorrect = false;
    void Start()
    {
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;  
    if (eventData.pointerDrag.name == this.name)
        {
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }
    }
    // Update is called once per frame

}
