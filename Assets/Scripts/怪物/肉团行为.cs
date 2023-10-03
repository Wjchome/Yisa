using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 肉团行为 : MonoBehaviour
{
    public GameObject Tear;
    public float HP;
    void Start()
    {
        HP = 15;
        StartCoroutine(Move());

    }
    IEnumerator Move()
    {

        Vector2 dir = Vector2.zero;
        while (true)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            int x = Random.Range(0, 4);
            if (x == 0)
            {
                dir = new Vector2(0, 1);
            }
            else if (x == 1)
            {
                dir = new Vector2(0, -1);

            }
            else if (x == 2)
            {
                dir = new Vector2(1, 0);

            }
            else if (x == 3)
            {
                dir = new Vector2(-1, 0);
            }
            GetComponent<Rigidbody2D>().AddForce(dir * 150);

            yield return new WaitForSeconds(1);
            Attack();
            yield return new WaitForSeconds(1);



        }


    }
    void Attack()
    {
        GameObject tear1 = Instantiate(Tear, transform.position, Quaternion.identity);
        tear1.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 1) * 150);
        GameObject tear2 = Instantiate(Tear, transform.position, Quaternion.identity);
        tear2.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 1) * 150);
        GameObject tear3 = Instantiate(Tear, transform.position, Quaternion.identity);
        tear3.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, -1) * 150);
        GameObject tear4 = Instantiate(Tear, transform.position, Quaternion.identity);
        tear4.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, -1) * 150);

        desTear(tear1);
        desTear(tear2);
        desTear(tear3);
        desTear(tear4);


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

    // Update is called once per frame
    void Update()
    {

    }
}
