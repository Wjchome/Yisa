using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 圆头怪Tear : MonoBehaviour
{
    public Animator animator;
    GameObject Player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.parent != null &&
        (other.transform.parent.name == "边界" || other.transform.parent.name == "石头"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Collider2D>().enabled = false;
            animator.SetTrigger("Break");
            Destroy(gameObject, 1);

        }
        else if (other.transform.parent != null &&
        other.transform.parent.name == "大便")
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Collider2D>().enabled = false;
            animator.SetTrigger("Break");
            Destroy(gameObject, 1);

            other.GetComponent<大便>().state++;
            other.GetComponent<SpriteRenderer>().sprite = other.GetComponent<大便>().大便state[other.GetComponent<大便>().state];
            if (other.GetComponent<大便>().state == 4)
            {
                other.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else if (other.transform.parent != null &&
        other.transform.parent.name == "炸药桶")
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Collider2D>().enabled = false;
            animator.SetTrigger("Break");
            Destroy(gameObject, 1);

            other.GetComponent<Animator>().SetTrigger("Boom");
            other.transform.GetChild(0).GetComponent<Collider2D>().enabled = true;
            Destroy(other.gameObject, 0.8f);


        }
        else if (other.gameObject == Player)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Collider2D>().enabled = false;
            animator.SetTrigger("Break");
            Destroy(gameObject, 1);

            GameObject.Find("PlayerData").GetComponent<PlayerData>().HP--;
        }



    }
    private void Start()
    {
        Player = GameObject.Find("Yisa");
    }

}
