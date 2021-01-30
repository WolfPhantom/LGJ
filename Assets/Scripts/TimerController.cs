using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerController : MonoBehaviour
{
    [SerializeField]
    GameObject timerBar;
    //public GameObject Timetxt;
    Timer timer;
    
    bool event1=false;

    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 30;
        timer.Run();
        //Timetxt.SetActive(false);

    }

    
    void Update()
    {
        if (!timer.Finished)
        {
            //print(timer.elapsedSeconds);
            if (event1==true)
            {
                event1 = false;
                LostTime();
                
            }
            timerBar.GetComponent<Image>().fillAmount = 1 - timer.elapsedSeconds / timer.totalSeconds;
            //print(timer.elapsedSeconds / timer.totalSeconds);
            
        }
        else
        {
            //Timetxt.SetActive(true);
            SceneManager.LoadScene("GameOver");
        }
    }
    public void LostTime() 
    {
        timer.elapsedSeconds += 5;
    }
    public void ActivateEvent() 
    {
        event1 = true;
    }
    
}
