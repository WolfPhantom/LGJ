using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    TimerController timer;

    [SerializeField]
    List<Image> objectsToFind;
    [SerializeField]
    List<Canvas> containers;
    [SerializeField]
    List<GameObject> containersTrigers;

    private GameObject objectToFindPanel;
    public Image objectToFind;
        
    void Start()
    {
        objectToFindPanel = GameObject.FindGameObjectWithTag("ObjectToFindPanel");
        objectToFind = objectsToFind[Random.Range(0, objectsToFind.Count)];
        Instantiate(objectToFind, objectToFindPanel.transform);
        containers[Random.Range(0, containers.Count)].GetComponent<InstanciateObjectsInBox>().InstantianteTargetObject(objectToFind);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) 
        {
            timer.ActivateEvent();

        }   
    }

    public void updateContainers(bool condition)
    {
        for (int i = 0; i < containersTrigers.Count; i++)
        {
            containersTrigers[i].GetComponent<AbrirCajon>().isOpen = condition;
        }
    }
    
}
