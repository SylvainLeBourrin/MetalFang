using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannetteTaken : MonoBehaviour
{
    public GameObject can;
    public Vector3 placement;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TakeMe"))
        {
            can.transform.SetParent(gameObject.transform);
            can.transform.position += placement;
        }
    }
}
