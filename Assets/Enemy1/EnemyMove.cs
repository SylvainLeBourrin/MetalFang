using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    Transform playerTransform;
    Vector2 range;
    Vector2 dir;
    public Animator animator;
    public Boal isJumping;
    bool isPunching;
    bool isDamage;
    public Boal isUp;
    public Boal notJumping;
    public Pos pos;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping.value = isDamage = isPunching = isUp.value = false;
        pos.value = Vector3.zero;
    }
    private void Start()
    {
        playerTransform = GameObject.Find("Movement").transform;
    }
    private void Update()
    {
        range = playerTransform.position - transform.position; 
        dir = range.normalized;

        // animators
        if (dir.x != 0 || dir.y != 0) animator.SetBool("E1Moving", true);
        else animator.SetBool("E1Moving", false);
        if (!isDamage && !isJumping.value && !isPunching)
        {
            if (dir.x < 0) animator.SetFloat("E1playerDirection", 1);
            else animator.SetFloat("E1playerDirection", 0);
        }
        if (Mathf.Abs(range.x) < 1.5f && Mathf.Abs(range.y) < 1.5f && Random.value < 0.9)
        {
            animator.SetBool("E1Punch", true);
            isPunching = true;
        }
        else
        {
            animator.SetBool("E1Punch", false);
            isPunching = false;
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
        if (isDamage || isJumping.value || isPunching) rb.velocity = Vector2.zero;
        //Jumping cba
        if (isJumping.value)
        {
            if (notJumping.value) rb.AddForce(Vector2.up * 5000 * Time.fixedDeltaTime);
            if (transform.position.y > pos.value.y + 1) animator.SetBool("E1JumpUp", true); 
            if (isUp.value) rb.AddForce(Vector2.down * 5000 * Time.fixedDeltaTime);
            if (transform.position.y < pos.value.y)
            {
                animator.SetBool("E1JumpDone", true);
            }
        }
    }
}
