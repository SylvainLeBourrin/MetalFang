using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public VarByte CountDead;
    public bool spawned;
    private void Awake()
    {
        CountDead.value = 0;
        spawned = false;
    }
    private void Update()
    {
        if (CountDead.value % 2 == 0) spawned = false;
        if (!spawned)
        {
            if (CountDead.value == 1)
            {
                Spawn(0);
            }
            if (CountDead.value == 5)
            {
                Spawn(0);
                Spawn(1);
            }   
            if (CountDead.value == 13)
            {
                Spawn(0);
                Spawn(1);
                Spawn(2);
            }
            SpawnInfinite();
        }
    }
    void Spawn(byte i)
    {
        Instantiate(enemy, transform.position + new Vector3(0, i, 0), Quaternion.identity);
        spawned = true;
    }
    void SpawnInfinite()
    {
        if (CountDead.value > 13 && CountDead.value % 2 == 1)
        {
            Spawn(0);
            Spawn(1);
            Spawn(2);
        }
    }
}
