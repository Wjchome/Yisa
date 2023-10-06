using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 金币 : MonoBehaviour
{
    PlayerData playerData;
    GameObject Player;
    public Animator animator;
    private void Start()
    {
        Player = GameObject.Find("Yisa");
        playerData = GameObject.Find("PlayerData").GetComponent<PlayerData>();
    }
    bool IsGet = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (IsGet == false)
        {
            if (other.gameObject == Player)
            {

                playerData.CodeNum++;
                IsGet = true;
                animator.SetBool("IsGet", true);
                Destroy(gameObject, 0.4f);
            }

        }
    }

}
