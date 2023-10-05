using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 炸药桶子 : MonoBehaviour
{
    PlayerData playerData;
    void Start()
    {
        playerData = GameObject.Find("PlayerData").GetComponent<PlayerData>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.parent != null &&
            other.transform.parent.name == "石头")
        {
            Destroy(other.gameObject);

        }
        else if (other.transform.parent != null &&
        other.transform.parent.name == "大便")
        {
            other.GetComponent<大便>().state = 4;
            other.GetComponent<SpriteRenderer>().sprite = other.GetComponent<大便>().大便state[other.GetComponent<大便>().state];
            if (other.GetComponent<大便>().state == 4)
            {
                other.GetComponent<BoxCollider2D>().enabled = false;
            }

        }
        else if (other.transform.parent != null &&
    other.transform.parent.name == "炸药桶")
        {


            other.GetComponent<Animator>().SetTrigger("Boom");
            Destroy(other.gameObject, 0.8f);


        }
        else if (other.name.Substring(0, 2) == "蜘蛛")
        {

            other.GetComponent<蜘蛛行为>().HP -= 15;
        }
        else if (other.name.Substring(0, 2) == "圆头虫")
        {

            other.GetComponent<圆头虫行为>().HP -= 15;
        }
        else if (other.name.Substring(0, 2) == "肥仔")
        {

            other.GetComponent<肥仔行为>().HP -= 15;
        }
        else if (other.name.Substring(0, 2) == "肉团")
        {
            other.GetComponent<肉团行为>().HP -= 15;
        }
        else if (other.tag == "Player")
        {
            playerData.HP -= 2;
        }

    }
}
