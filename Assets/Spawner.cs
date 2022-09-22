using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    private void Update()
    {
        Instantiate(enemy);
    }
}
