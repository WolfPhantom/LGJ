﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    TimerController timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) 
        {
            timer.ActivateEvent();

        }   
    }
    
}
