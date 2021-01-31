using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler, IPointerClickHandler
{
    private TimerController timerController;
    
    public static GameObject itemDragging;

    Transform startParent;
    Transform dragParent;
    //Image
    float halfColliderWidth;
    float halfColliderHeight;
    //Background 

    GameObject background;
    float halfColliderWidthB;
    float halfColliderHeightB;
    float minX = 450;
    float maxX = 1450;
    float minY = 195;
    float maxY = 900;

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
        desirePosition = CalculateClamped(desirePosition);
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
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.clickCount == 2)
        {
            if (gameObject.tag=="ObjectToFind")
            {
                //Time.timeScale = 0;
                timerController.transition();
                //Debug.Log("GarageLevel");
            }
            else
            {
                //Debug.Log("Tu mama");
                timerController.LostTime();
            }
            //Debug.Log("Double Click");
            //Debug.Log(Input.mousePosition);
            eventData.clickCount = 0;
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        //background = GameObject.FindGameObjectWithTag("CajonBackground");
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;


        //halfColliderWidth = GetComponent<RectTransform>().rect.width / 2;
        //halfColliderHeight = GetComponent<RectTransform>().rect.height / 2;

        //halfColliderWidthB = background.GetComponent<RectTransform>().rect.width / 2;
        //halfColliderHeightB = background.GetComponent<RectTransform>().rect.height / 2;



        //minX = background.GetComponent<RectTransform>().localPosition.x - halfColliderWidthB;
        //maxX = background.GetComponent<RectTransform>().localPosition.x + halfColliderWidthB;

        //minY = background.GetComponent<RectTransform>().localPosition.y - halfColliderHeightB;
        //maxY = background.GetComponent<RectTransform>().localPosition.y + halfColliderHeightB;

        //print("halfColliderWidth: " + halfColliderWidth);
        //print("halfColliderHeight: " + halfColliderHeight);
        //print("halfColliderWidthB: " + halfColliderWidthB);
        //print("halfColliderHeightB: " + halfColliderHeightB);
        //print("minX: " + minX);
        //print("maxX: " + maxX);
        //print("minY: " + minY);
        //print("maxY: " + maxY);

        
        
        timerController = GameObject.FindGameObjectWithTag("GameController").GetComponent<TimerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Vector3 CalculateClamped(Vector3 position)
    {
        //print(position);
        // clamp left and right edges
        if (position.x - halfColliderWidth < minX)
        {
            position.x = minX + halfColliderWidth;
        }
        else if (position.x + halfColliderWidth > maxX)
        {
            position.x = maxX - halfColliderWidth;
        }
        if (position.y - halfColliderHeight < minY)
        {
            position.y = minY + halfColliderHeight;
        }
        else if (position.y + halfColliderHeight > maxY)
        {
            position.y = maxY - halfColliderHeight;
        }
        return position;
    }
}
