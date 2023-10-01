using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float Speed;
    public float HP;
    public float RateFire;//射速
    public float SpeedFire;//弹速
    public float AttackPower;

    public int []道具;

    private void Awake()
    {
        Speed=8;

        RateFire=0.5f;

        SpeedFire=200;

        道具=new int[3];
    }
}
