using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject Tear;
    public GameObject Boom;
    public PlayerData playerData;

    int Rate = 10;
    private void Start()
    {
        playerData = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        StartCoroutine(fire());
        StartCoroutine(Boomfire());

    }

    bool IsFire = false;
    bool IsCool = false;
    IEnumerator desTear(GameObject Tear)
    {
        yield return new WaitForSeconds(0.7f);
        Tear.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Tear.GetComponent<Collider2D>().enabled = false;
        Tear.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Break");
        yield return new WaitForSeconds(1f);
        Destroy(Tear);

    }
    IEnumerator Boomfire()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.E) && playerData.BoomNum > 0)
            {
                playerData.BoomNum--;
                Instantiate(Boom, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
            }
            yield return null;

        }

    }
    IEnumerator fire()
    {
        while (true)
        {
            if (IsCool == false)
            {
                Vector2 FireDir = new Vector2(0, 0);

                if (Input.GetKey(KeyCode.UpArrow))
                {
                    FireDir = new Vector2(0, 2);
                    IsFire = true;

                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    FireDir = new Vector2(0, -2);
                    IsFire = true;

                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    FireDir = new Vector2(2, 0);
                    IsFire = true;

                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    FireDir = new Vector2(-2, 0);
                    IsFire = true;

                }
                else if (Input.GetMouseButton(0))
                {
                    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector2 vector2 = worldPosition - transform.position;
                    IsFire = true;

                    if (Mathf.Abs(vector2.y) > Mathf.Abs(vector2.x))
                    {
                        if (vector2.y > 0)
                        {
                            FireDir = new Vector2(0, 2);
                        }
                        else
                        {
                            FireDir = new Vector2(0, -2);
                        }
                    }
                    else
                    {
                        if (vector2.x > 0)
                        {
                            FireDir = new Vector2(2, 0);
                        }
                        else
                        {
                            FireDir = new Vector2(-2, 0);
                        }
                    }

                }

                if (IsFire)
                {
                    GameObject tear = Instantiate(Tear, transform.position, Quaternion.identity);

                    tear.GetComponent<Rigidbody2D>().AddForce(
                    (FireDir + GetComponent<Rigidbody2D>().velocity / Rate)
                    * playerData.SpeedFire);
                    StartCoroutine(desTear(tear));


                    IsFire = false;
                    IsCool = true;
                }



            }



            if (IsCool == true)
            {
                yield return new WaitForSeconds(playerData.RateFire);
                IsCool = false;
            }
            else
            {
                yield return null;
            }
        }

    }


}