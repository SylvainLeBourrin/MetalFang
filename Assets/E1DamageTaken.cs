using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1DamageTaken : MonoBehaviour
{
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Punch"))
        {
            animator.SetTrigger("E1Dead");
        }
    }
}
