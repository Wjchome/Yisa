using System.Collections;
using System.Collections.Generic;
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
        GameObject a = Instantiate(金币, transform.position, Quaternion.identity);
        a.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));
        GameObject b = Instantiate(钥匙, transform.position, Quaternion.identity);
        b.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));
        GameObject c = Instantiate(炸弹, transform.position, Quaternion.identity);
        c.GetComponent<炸弹>().IsGet = true;
        c.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)));

    }

}
