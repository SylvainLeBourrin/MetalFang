using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("Punch", true);
        }
        else animator.SetBool("Punch", false);
    }
}
