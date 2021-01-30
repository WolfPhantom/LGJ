using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciateObjectsInBox : MonoBehaviour
{
    [SerializeField] private List<Image> movableObjects;

    [SerializeField] private int CantObjects = 5;

    [SerializeField] private Vector2 LeftBottomCorner;
    [SerializeField] private Vector2 RightTopCorner;

    private Vector3 ObjectToFindPosition;

    Image img;

    // Start is called before the first frame update
    void Start()
    {
        if (img)
        {
            ObjectToFindPosition = new Vector3(
                    Random.Range(LeftBottomCorner.x, RightTopCorner.x),
                    Random.Range(LeftBottomCorner.y, RightTopCorner.y),
                    transform.position.z);
            img.transform.position = ObjectToFindPosition;
        }

        for (int i = 0; i < CantObjects; i++) {
            int index = Random.Range(0, movableObjects.Count);
            Vector3 randomPosition = new Vector3(
                Random.Range(LeftBottomCorner.x, RightTopCorner.x),
                Random.Range(LeftBottomCorner.y, RightTopCorner.y),
                transform.position.z);
            Debug.Log(randomPosition);
            Image img = Instantiate(movableObjects[index], randomPosition, new Quaternion(0f, 0f, 0f, 0f), transform.GetChild(2));
            img.transform.rotation = new Quaternion(0f, 0f, Random.Range(-100, 100) / 100f, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantianteTargetObject(Image targetObject)
    {
        
        //Debug.Log(ObjectToFindPosition);
        img = Instantiate(targetObject, Vector3.zero, new Quaternion(0f, 0f, 0f, 0f), transform.GetChild(2));
        //Debug.Log(img.transform.position);
        img.transform.rotation = new Quaternion(0f, 0f, Random.Range(-100, 100) / 100f, 1);
    }
}
