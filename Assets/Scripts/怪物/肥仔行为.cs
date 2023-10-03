using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 肥仔行为 : MonoBehaviour
{
    Transform Player;
    public GameObject Leg;

    public float HP;
    void Start()
    {
        HP = 20;
        Player = GameObject.Find("Yisa").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = (Player.position - transform.position).normalized;
        if (dir.x > 0)
        {
            Leg.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            Leg.transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Mathf.Abs(dir.y) > Mathf.Abs(dir.x))
        {
            Leg.GetComponent<Animator>().SetBool("just", true);
        }
        else
        {
            Leg.GetComponent<Animator>().SetBool("just", false);
        }
        GetComponent<Rigidbody2D>().AddForce(dir * 100 * Time.deltaTime);

        if (HP <= 0)
        {
            Destroy(gameObject);
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
