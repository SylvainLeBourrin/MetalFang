using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public Transform playerTransform;
    Vector2 dir;
    public Animator animator;
    public Boal isJumping;
    public Boal isPunching;
    public Boal isDamage;
    public Boal isUp;
    public Boal notJumping;
    public Pos pos;
    public float p;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping.value = isDamage.value = isPunching.value = isUp.value = false;
        pos.value = Vector3.zero;
    }
    private void Update()
    {
        dir = (playerTransform.position - transform.position).normalized;
        // animators
        if (dir.x != 0 && dir.y != 0) animator.SetBool("E1Moving", true);
        else animator.SetBool("E1Moving", false);
        if (dir.x < 0) animator.SetFloat("E1playerDirection", 1);
        else animator.SetFloat("E1playerDirection", 0);
        //if (Random.value > 0.998) animator.SetTrigger("Punch");
        //if (Input.GetButtonDown("Fire1")) animator.SetTrigger("Jump");
        if (isJumping.value)
        {
            /*if (notJumping.value) transform.position += Vector3.up * jumpForce;
            if (transform.position.y > pos.value.y + 1) animator.SetBool("JumpUp", true);
            if (isUp.value) transform.position += Vector3.down * jumpForce;
            if (transform.position.y < pos.value.y)
            {
                animator.SetBool("JumpDone", true);
                animator.SetBool("JumpUp", false);
            }*/
        }
        if (!isJumping.value)
        {
            animator.SetBool("E1JumpDone", false);
            animator.SetBool("E1JumpUp", false);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = dir * speed * Time.fixedDeltaTime;
        if (isDamage.value || isJumping.value || isPunching.value) rb.velocity = Vector2.zero;
        if (isJumping.value)
        {
            if (notJumping.value) rb.AddForce(Vector2.up * 5000 * Time.fixedDeltaTime);
            if (transform.position.y > pos.value.y + 1) animator.SetBool("E1JumpUp", true); 
            if (isUp.value) rb.AddForce(Vector2.down * 5000 * Time.fixedDeltaTime);
            if (transform.position.y < pos.value.y + p)
            {
                animator.SetBool("E1JumpDone", true);
            }
        }
    }
}
