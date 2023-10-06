using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 地刺 : MonoBehaviour
{
    public GameObject Player;
    public PlayerData playerData;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            playerData.HP--;
        }

    }
}
