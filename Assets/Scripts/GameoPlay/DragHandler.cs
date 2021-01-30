using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler, IPointerDownHandler
{
    public static GameObject itemDragging;

    Transform startParent;
    Transform dragParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
        itemDragging = gameObject;

        startParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        Vector3 desirePosition = Input.mousePosition;
        desirePosition.z = 10.0f;
        transform.position = Camera.main.ScreenToWorldPoint(desirePosition); ;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
        itemDragging = null;

        if (transform.parent == dragParent)
        {
            transform.SetParent(startParent);
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.clickCount == 2)
        {
            if (gameObject.tag=="ObjectToFind")
            {
                Debug.Log("Encontrado");
            }
            else
            {
                Debug.Log("Tu mama");
            }
            Debug.Log("Double Click");
            //Debug.Log(Input.mousePosition);
            eventData.clickCount = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
