using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 圆头虫行为 : MonoBehaviour
{
    public Animator animator;

    Transform cam;

    public GameObject 血泪;
    public GameObject Player;

    public float HP;
    void Start()
    {
        HP = 10;
        Player = GameObject.Find("Yisa");
        cam = GameObject.Find("Camera").transform;
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        while (true)
        {
            animator.SetBool("Attack", true);
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            yield return new WaitForSeconds(0.9f);


            _Attack();
            yield return new WaitForSeconds(0.9f);
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            GetComponent<CircleCollider2D>().enabled = false;
            GetComponentInChildren<SpriteRenderer>().enabled = false;
            animator.SetBool("Attack", false);


            transform.position = new Vector2(cam.position.x + Random.Range(-3f, 3f), cam.position.y + Random.Range(-3f, 3f));

            yield return new WaitForSeconds(2f);
            GetComponent<CircleCollider2D>().enabled = true;
            GetComponentInChildren<SpriteRenderer>().enabled = true;

        }


    }
    void _Attack()
    {
        if ((Player.transform.position - transform.position).magnitude < 6)
        {
            GameObject tear = Instantiate(血泪, transform.position, Quaternion.identity);
            tear.GetComponent<Rigidbody2D>().AddForce(
                (Player.transform.position - transform.position).normalized * 200);
            desTear(tear);

        }


    }
    IEnumerator desTear(GameObject Tear)
    {
        yield return new WaitForSeconds(0.7f);
        Tear.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Tear.GetComponent<Collider2D>().enabled = false;
        Tear.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Break");
        yield return new WaitForSeconds(1f);
        Destroy(Tear);

    }
    private void Update()
    {
        if (HP <= 0)
        {

            Destroy(gameObject);
        }
    }

}
