using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 钥匙 : MonoBehaviour
{
    PlayerData playerData;
    GameObject Player;

    private void Start()
    {
        Player = GameObject.Find("Yisa");
        playerData = GameObject.Find("PlayerData").GetComponent<PlayerData>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject == Player)
        {

            playerData.KeyNum++;
            Destroy(gameObject);

        }

    }
}


