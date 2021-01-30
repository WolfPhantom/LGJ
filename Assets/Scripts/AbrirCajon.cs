using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCajon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    List<AudioClip> audios;
    AudioSource _audioSource;
    [SerializeField]
    GameObject gameplayController;
    [HideInInspector]
    public bool isOpen = false;

    void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            _audioSource.clip = audios[1];
            _audioSource.Play();
            gameplayController.GetComponent<GameplayController>().updateContainers(false);
        }
    }
    private void OnMouseDown()
    {
        if (isOpen == false)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            _audioSource.clip = audios[0];
            _audioSource.Play();
            gameplayController.GetComponent<GameplayController>().updateContainers(true);
        }
    }
    
}
