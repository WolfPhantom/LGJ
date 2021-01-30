using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    private Animator fade;

    void Start()
    {
        fade = GetComponent<Animator>();
    }

    public void LoadScene(string scene)
    {
        StartCoroutine(TransitionTo(scene));
    }

    IEnumerator TransitionTo(string scene)
    {
        fade.SetTrigger("exit");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
