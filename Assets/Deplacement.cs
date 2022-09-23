using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector3 Move;
    public float Speed = 20f;
    float Hx;
    float Vy;
    public Animator animator;
    float orientation;
    void Update()
    {
        Hx = Input.GetAxis("Horizontal");
        Vy = Input.GetAxis("Vertical");
        Move = new Vector3(Hx, Vy, 0);
        if (Hx != 0) orientation = Hx;
        if (orientation < 0) animator.SetFloat("playerDirection", 1);
        else animator.SetFloat("playerDirection", 0);
    }
    void FixedUpdate()
    {
        rb.velocity = Move * Speed * Time.fixedDeltaTime;
        if (rb.velocity.x != 0 || rb.velocity.y != 0) animator.SetBool("Moving", true);
        else animator.SetBool("Moving", false);
    }
}
