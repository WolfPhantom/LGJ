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
    [SerializeField]
    Image blur;
    [SerializeField]
    Image fade;
    public string nextLevel;

    bool event1=false;

    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 30;
        timer.Run();
        //Timetxt.SetActive(false);
        blur.GetComponent<Image>().material.SetFloat("_Size", 0);
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

            if((int)timer.elapsedSeconds < 10)
            {
                blur.GetComponent<Image>().material.SetFloat("_Size", 0);
            } 
            else if((int)timer.elapsedSeconds < 20)
            {
                blur.GetComponent<Image>().material.SetFloat("_Size", 2);
            }
            else
            {
                blur.GetComponent<Image>().material.SetFloat("_Size", 4);
            }


        }
        else
        {
            //Timetxt.SetActive(true);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void LostTime() 
    {
        timer.elapsedSeconds += 2;
    }

    public void ActivateEvent() 
    {
        event1 = true;
    }
    
    public void transition()
    {
        fade.GetComponent<Transition>().LoadScene(nextLevel);
    }

}
