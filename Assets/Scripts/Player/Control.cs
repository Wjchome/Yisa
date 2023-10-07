using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject gameObjects;

    void Start()
    {

    }

    public bool IsPause = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && IsPause == false)
        {
            gameObjects.SetActive(true);
            Time.timeScale = 0;
            IsPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && IsPause == true)
        {
            gameObjects.SetActive(false);
            Time.timeScale = 1;
            IsPause = false;
        }

    }
}
