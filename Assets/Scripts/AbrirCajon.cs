﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCajon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    
}
