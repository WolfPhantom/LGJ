using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Button btnMenu;
    void Start()
    {
        btnMenu.onClick.AddListener(() => GoMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GoMenu() 
    {
        SceneManager.LoadScene("Menu");
    }
}
