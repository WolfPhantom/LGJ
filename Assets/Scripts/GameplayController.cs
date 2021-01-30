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
    private Image objectToFindPanelEscena;
    public Image objectToFind;


    [SerializeField]
    public GameObject _dialoguePanel;


    public static bool GameIsPause = false;
    void Start()
    {
        StartCoroutine(Pause());
        objectToFindPanel = GameObject.FindGameObjectWithTag("ObjectToFindPanel");
        objectToFindPanelEscena = GameObject.FindGameObjectWithTag("ImagenDialogo").GetComponent<Image>();
        objectToFind = objectsToFind[Random.Range(0, objectsToFind.Count)];
        Instantiate(objectToFind, objectToFindPanel.transform);
        objectToFindPanelEscena.sprite = objectToFind.sprite;
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
    IEnumerator Pause()
    {

        yield return new WaitForSeconds(3f);
        _dialoguePanel.SetActive(false);
        timer.Initializeed();


    }

}
