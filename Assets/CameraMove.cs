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
        transform.position = new Vector3 (playerTransform.position.x, playerTransform.position.y, -10);    
    }
}
