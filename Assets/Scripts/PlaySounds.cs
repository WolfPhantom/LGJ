using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    List<AudioClip> audios;
    AudioSource _audioSource;
    
    void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
        StartCoroutine(EventoChancla());
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator EventoChancla() 
    {
        yield return new WaitForSeconds(3.5f);
        _audioSource.clip = audios[1];
        _audioSource.Play();
        yield return new WaitForSeconds(1);
        _audioSource.clip = audios[0];
        _audioSource.Play();
    }
}
