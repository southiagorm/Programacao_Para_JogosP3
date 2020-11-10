using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Animator anim;
    private float h;

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");

        anim.SetFloat("run", Mathf.Abs(h));
    }
}
