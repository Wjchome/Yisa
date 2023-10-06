using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float MoveSpeed;
    public float HP;
    public float MaxHP;
    public float RateFire;//射速
    public float SpeedFire;//弹速
    public float AttackPower;

    public int BoomNum = 1;
    public int KeyNum = 1;
    public int CodeNum = 1;

    public int[] 道具;

    private void Awake()
    {
        MoveSpeed = 6;


        HP = 6;

        MaxHP = 6;

        RateFire = 0.5f;

        SpeedFire = 200;

        AttackPower = 5;

        道具 = new int[3];
    }

}
