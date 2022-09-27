using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;
    private void Awake()
    {
        playerTransform = GameObject.Find("Movement").transform;
    }
    private void Update()
    {
        if (playerTransform.position.x > -2.1f && playerTransform.position.x < 3.1f)
        {
            transform.position = new Vector3(playerTransform.position.x, transform.position.y, -10);
        }
    }
}
