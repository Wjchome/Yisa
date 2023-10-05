using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class 门fun : MonoBehaviour
{
    public bool Open;
    GameObject Cam;
    GameObject Player;
    void Start()
    {
        Cam = GameObject.Find("Camera");
        Player = GameObject.Find("Yisa");

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Open == true)
        {
            if (other.gameObject == Player)
            {
                Player.transform.position = 2 * transform.position - Player.transform.position;
                Cam.transform.position = 2 * transform.position - Cam.transform.position;
                Cam.transform.position = new Vector3(Cam.transform.position.x, Cam.transform.position.y, -10);
            }


        }
    }


}
