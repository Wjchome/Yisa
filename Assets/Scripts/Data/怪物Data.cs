using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 怪物Data : MonoBehaviour
{
    public GameObject[] 怪物;

    public GameObject[] doors;
    public GameObject Player;
    public GameObject 金币;
    public GameObject 钥匙;
    public GameObject 炸弹;

    public bool[] IsFinish;

    public GameObject Cam;
    void Start()
    {
        IsFinish = new bool[5];

    }

    // Update is called once per frame
    void Update()
    {
        fun1();
        fun2();
        fun3();
        fun4();
        fun5();




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
        if (怪物[0] == null && 怪物[1] == null && IsFinish[0] == false)
        {
            doors[0].GetComponent<门fun>().Open = true;
            doors[1].GetComponent<门fun>().Open = true;
            GetReward();
            IsFinish[0] = true;
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
        if (怪物[2] == null && 怪物[3] == null && IsFinish[1] == false)
        {
            GetReward();
            IsFinish[1] = true;
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
        if (怪物[4] == null && 怪物[5] == null && 怪物[6] == null && 怪物[7] == null && IsFinish[2] == false)
        {
            doors[2].GetComponent<门fun>().Open = true;

            GetReward();
            IsFinish[2] = true;
        }
    }
    void fun4()
    {
        if (-22.5f < Player.transform.position.y && Player.transform.position.y < -14.5 &&
        -4.5f < Player.transform.position.x && Player.transform.position.x < 10.5 &&
        怪物[8] != null && 怪物[9] != null)
        {
            怪物[8].SetActive(true);
            怪物[9].SetActive(true);
        }
        if (怪物[8] == null && 怪物[9] == null && IsFinish[3] == false)
        {
            doors[3].GetComponent<门fun>().Open = true;
            doors[4].GetComponent<门fun>().Open = true;

            GetReward();
            IsFinish[3] = true;
        }

    }
    void fun5()
    {
        if (-32.5f < Player.transform.position.y && Player.transform.position.y < -24.5 &&
        -4.5f < Player.transform.position.x && Player.transform.position.x < 10.5 &&
        怪物[10] != null && 怪物[11] != null && 怪物[12] != null && 怪物[13] != null)
        {
            怪物[10].SetActive(true);
            怪物[11].SetActive(true);
            怪物[12].SetActive(true);
            怪物[13].SetActive(true);
        }
        if (怪物[10] == null && 怪物[11] == null && 怪物[12] == null && 怪物[13] == null && IsFinish[4] == false)
        {
            doors[5].GetComponent<门fun>().Open = true;
            GetReward();
            IsFinish[4] = true;
        }
    }
    void fun6()
    {
        if (-41.5f < Player.transform.position.y && Player.transform.position.y < -344.5 &&
        -4.5f < Player.transform.position.x && Player.transform.position.x < 10.5 &&
        怪物[14] != null && 怪物[15] != null)
        {
            怪物[14].SetActive(true);
            怪物[15].SetActive(true);

        }

    }
    void GetReward()
    {
        int a = Random.Range(0, 3);
        if (a != 0)
        {
            int b = Random.Range(0, 3);
            if (b == 0)
            {
                CodeShow();

            }
            else if (b == 1)
            {
                KeyShow();

            }
            else
            {
                BoomShow();

            }


        }

    }
    void CodeShow()
    {
        GameObject aa = Instantiate(金币, Cam.transform.position + new Vector3(0, 0, 10), Quaternion.identity);
        aa.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));

    }
    void KeyShow()
    {
        GameObject bb = Instantiate(钥匙, Cam.transform.position + new Vector3(0, 0, 10), Quaternion.identity);
        bb.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));
    }
    void BoomShow()
    {
        GameObject c = Instantiate(炸弹, Cam.transform.position + new Vector3(0, 0, 10), Quaternion.identity);
        c.GetComponent<炸弹>().IsGet = true;
        c.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));
    }

}
