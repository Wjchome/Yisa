using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 终点 : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            Application.Quit();

        }
    }
}
