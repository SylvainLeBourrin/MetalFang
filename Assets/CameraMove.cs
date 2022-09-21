using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerTransform;
    private void Update()
    {
        transform.position = new Vector3 (transform.position.x, transform.position.y, -10);    
    }
}
