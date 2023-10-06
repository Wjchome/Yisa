using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 传送门 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cam;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.position = new Vector3(-13, -18, 0);
            Cam.transform.position = new Vector3(-13, -18, -10);

        }

    }
}
