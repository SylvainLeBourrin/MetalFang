using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public AnimationCurve jumpCurve;
    float jumpTimer;
    public Animator animator;
    Transform sprite;
    public float jumpHeight;
    public float jumpDuration;
    bool isJumping;
    private void Awake()
    {
        jumpTimer = 0;
        sprite = transform.Find("Sprite");
        isJumping = false;
    }
    private void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            animator.SetBool("Jump", true);
            isJumping = true;
        }
        else animator.SetBool("Jump", false);
        if (isJumping)
        {
            JumpScript();
        }
    }
    void JumpScript()
    {
        if (jumpTimer < jumpDuration)
        {
            jumpTimer += Time.deltaTime;
            float y = jumpCurve.Evaluate(jumpTimer / jumpDuration);
            sprite.position = transform.position + new Vector3(0, y * jumpHeight, 0);
        }
        else
        {
            jumpTimer = 0;
            isJumping = false;
        }
    }
}
