using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    [SerializeField]
    Button playButton;

    [SerializeField]
    Button quitButton;

    
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(() => GoGameplay());
        quitButton.onClick.AddListener(() => Quit());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GoGameplay() 
    {
        SceneManager.LoadScene("Gameplay");
    }
     void Quit()
    {
        Application.Quit();
            
    }

}
