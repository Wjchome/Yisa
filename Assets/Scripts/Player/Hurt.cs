using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurt : MonoBehaviour
{
    public PlayerData playerData;

    public SpriteRenderer Head, Leg;
    public float HP;
    void Start()
    {
        HP = playerData.HP;
    }

    bool Ishurt = false;
    void Update()
    {
        if (HP != playerData.HP && Ishurt == false)
        {
            HP = playerData.HP;
            Ishurt = true;
            StartCoroutine(Hurtfun());

        }
        if (Ishurt == true)
        {
            playerData.HP = HP;
        }

        if (HP <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    IEnumerator Hurtfun()
    {
        for (int i = 0; i < 3; i++)
        {
            Head.color = Color.red;
            Leg.color = Color.red;
            yield return new WaitForSeconds(0.05f);
            Head.color = Color.white;
            Leg.color = Color.white;
            yield return new WaitForSeconds(0.05f);

        }
        Ishurt = false;

    }
}
