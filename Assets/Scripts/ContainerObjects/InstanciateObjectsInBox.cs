using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciateObjectsInBox : MonoBehaviour
{
    [SerializeField] private List<Image> movableObjects;

    [SerializeField] private int CantObjects = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < CantObjects; i++) {
            int index = Random.Range(0, movableObjects.Count);
            Instantiate(movableObjects[index], transform.position, new Quaternion(0f, 0f, 0f, 0f), transform.GetChild(2));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
