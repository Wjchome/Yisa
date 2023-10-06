using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolCheck : MonoBehaviour
{
    PlayerData playerData;
    void Start()
    {
        playerData = GameObject.Find("PlayerData").GetComponent<PlayerData>();

    }

    bool Ispool3 = false;
    void Update()
    {
        if (playerData.道具[2] >= 1 && Ispool3 == false)
        {
            Debug.Log("ok1");
            playerData.MaxHP += 2;
            playerData.MoveSpeed *= 1.3f;
            playerData.SpeedFire *= 1.25f;
            playerData.RateFire /= 1.2f;

            playerData.AttackPower *= 1.3f;

            Ispool3 = true;

        }

    }
}
