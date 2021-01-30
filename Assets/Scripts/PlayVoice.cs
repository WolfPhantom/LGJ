using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoice : MonoBehaviour
{
    [SerializeField]
    private AudioSource voice;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake()
    {
        voice.PlayDelayed(0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
