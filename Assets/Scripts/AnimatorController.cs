using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject madre;
    [SerializeField]
    GameObject mano;

    Animator _animator;
    void Start()
    {
        _animator = mano.GetComponent<Animator>();
        mano.SetActive(false);
        StartCoroutine(AparecerMano());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator AparecerMano() 
    {
        
        mano.SetActive(true);
        yield return new WaitForSeconds(4f);
        _animator.SetBool("Lanzando", true);

    }
    
    
}
