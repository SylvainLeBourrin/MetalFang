using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void LoadGamu()
    {
        SceneManager.LoadScene(1);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene(1);
        }
    }
}
