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
    void Update()
    {
        Hx = Input.GetAxis("Horizontal");
        Vy = Input.GetAxis("Vertical");
        Move = new Vector3(Hx, Vy, 0);
    }
    void FixedUpdate()
    {
        rb.velocity = Move * Speed * Time.fixedDeltaTime;  
    }
}
