using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;
    [SerializeField]
    private float offset;
    private Vector2 starPos;
    private float newXpos;

    // Start is called before the first frame update
    void Start()
    {
        starPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newXpos = Mathf.Repeat(Time.time * -moveSpeed, offset);
        transform.position = starPos + Vector2.right * newXpos;
    }
}
