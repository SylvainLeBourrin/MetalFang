using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerTransform;
    private void Update()
    {
        transform.position = new Vector3 (playerTransform.position.x, playerTransform.position.y, -10);    
    }
}
