using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)) && (animator.GetBool("isRotating")))
        {
            animator.SetBool("isRotating", false);
        }
        else if ((Input.GetKeyDown(KeyCode.Space)) && (!animator.GetBool("isRotating")))
        {
            animator.SetBool("isRotating", true); 
        }
    }
}
