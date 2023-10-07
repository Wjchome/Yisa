using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class 宝箱 : MonoBehaviour
{
    PlayerData playerData;
    public GameObject Player;

    public GameObject 炸弹;
    public GameObject 钥匙;
    public GameObject 金币;

    private void Start()
    {
        playerData = GameObject.Find("PlayerData").GetComponent<PlayerData>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == Player && playerData.KeyNum > 0)
        {

            playerData.KeyNum--;
            GetSomething();
            Destroy(gameObject);
        }
    }
    void GetSomething()
    {
        int a = Random.Range(0, 3);
        if (a == 0)
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
        else
        {
            int b = Random.Range(0, 3);
            if (b == 0)
            {
                CodeShow();
                BoomShow();



            }
            else if (b == 1)
            {
                CodeShow();
                KeyShow();
            }
            else
            {
                BoomShow();
                KeyShow();

            }

        }

    }
    void CodeShow()
    {
        GameObject aa = Instantiate(金币, transform.position, Quaternion.identity);
        aa.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));

    }
    void KeyShow()
    {
        GameObject bb = Instantiate(钥匙, transform.position, Quaternion.identity);
        bb.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));
    }
    void BoomShow()
    {
        GameObject c = Instantiate(炸弹, transform.position, Quaternion.identity);
        c.GetComponent<炸弹>().IsGet = true;
        c.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));
    }

}
