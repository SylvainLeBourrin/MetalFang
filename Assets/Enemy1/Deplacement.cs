using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public GameObject Players;
    public Rigidbody2D rb;
    public Vector3 Move;
    public float Speed = 20f;
    public float Hx;
    public float Vy;
    public GameObject Cannette;
   

    void Start()
    {
       // GetComponent<Collider2D>(Players);
        // GetComponent<Collider2D>(Cannette);
    }


    // Update is called once per frame
    void Update()
    {
        Hx = Input.GetAxis("Horizontal");
        Vy = Input.GetAxis("Vertical");
        Move = new Vector3(Hx, Vy, 0);

        // Prendre un Objet
        //If  crush and Collision then , Action

       

    }
    void FixedUpdate()
    {
        rb.velocity = Move * Speed;  

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       // if (collision.CompareTag("Player"))
        //{
            
        //}
    }
    // private void Ont(Collider other) // to see when the player enters the collider
  //  {
           
        

   // }
   // private void OnTriggerExit(Collider other)
  //  {
       

   // }


}
