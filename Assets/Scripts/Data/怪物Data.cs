using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 怪物Data : MonoBehaviour
{
    public GameObject[] 怪物;

    public GameObject[] doors;
    public GameObject Player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fun1();
        fun2();
        fun3();
        fun4();



    }
    void fun1()
    {
        if (5.5f < Player.transform.position.y && Player.transform.position.y < 13.5 &&
        9.5f < Player.transform.position.x && Player.transform.position.x < 23.5 &&
        怪物[0] != null && 怪物[1] != null)
        {
            怪物[0].SetActive(true);
            怪物[1].SetActive(true);
        }
        if (怪物[0] == null && 怪物[1] == null)
        {
            doors[0].GetComponent<门fun>().Open = true;
            doors[1].GetComponent<门fun>().Open = true;
        }

    }
    void fun2()
    {
        if (5.5f < Player.transform.position.y && Player.transform.position.y < 13.5 &&
        25.5f < Player.transform.position.x && Player.transform.position.x < 39.5 &&
        怪物[2] != null && 怪物[3] != null)
        {
            怪物[2].SetActive(true);
            怪物[3].SetActive(true);
        }


    }
    void fun3()
    {
        if (-4.5f < Player.transform.position.y && Player.transform.position.y < 3.5 &&
        9.5f < Player.transform.position.x && Player.transform.position.x < 23.5 &&
        怪物[4] != null && 怪物[5] != null && 怪物[6] != null && 怪物[7] != null)
        {
            怪物[4].SetActive(true);
            怪物[5].SetActive(true);
            怪物[6].SetActive(true);
            怪物[7].SetActive(true);
        }
        if (怪物[4] == null && 怪物[5] == null && 怪物[6] == null && 怪物[7] == null)
        {
            doors[2].GetComponent<门fun>().Open = true;
        }
    }
    void fun4()
    {
        if (-4.5f < Player.transform.position.y && Player.transform.position.y < 3.5 &&
        -7.5f < Player.transform.position.x && Player.transform.position.x < 7.5 &&
        怪物[8] != null && 怪物[9] != null)
        {
            怪物[8].SetActive(true);
            怪物[9].SetActive(true);
        }
        if (怪物[8] == null && 怪物[9] == null)
        {
            doors[3].GetComponent<门fun>().Open = true;
        }

    }


}
