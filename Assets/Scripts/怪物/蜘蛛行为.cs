using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 蜘蛛行为 : MonoBehaviour
{
    public float HP;

    Transform Player;

    public Animator animator;

    Coroutine MoveCor;
    void Start()
    {
        Player = GameObject.Find("Yisa").transform;
        HP = 6.5f;
        MoveCor = StartCoroutine(Move());
    }
    float x;
    float y;
    bool IsFind = false;
    IEnumerator Move()
    {
        while (true)
        {
            if (IsFind == false)
            {
                x = Random.Range(-1f, 1f);
                y = Random.Range(-1f, 1f);
                GetComponent<Rigidbody2D>().AddForce(new Vector2(x, y).normalized * 120);

            }
            else
            {
                GetComponent<Rigidbody2D>().AddForce((Player.position - transform.position).normalized * 120);
            }

            yield return new WaitForSeconds(2f);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            yield return new WaitForSeconds(1f);
        }
    }
    private void Update()
    {
        if ((Player.position - transform.position).magnitude < 5)
        {
            IsFind = true;
        }
        else
        {
            IsFind = false;
        }

        if (HP <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Collider2D>().enabled = false;
            StopCoroutine(MoveCor);
            animator.SetTrigger("Death");
            Destroy(gameObject, 1);



        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == Player.gameObject)
        {
            GameObject.Find("PlayerData").GetComponent<PlayerData>().HP--;
        }

    }


}
