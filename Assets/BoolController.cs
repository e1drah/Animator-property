using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolController : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W)) && (animator.GetBool("isRotating")))
        {
            animator.SetBool("isRotating", false);
        }
        else if ((Input.GetKeyDown(KeyCode.W)) && (!animator.GetBool("isRotating")))
        {
            animator.SetBool("isRotating", true); 
        }
    }
}
