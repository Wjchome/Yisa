using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 道具 : MonoBehaviour
{
    public Sprite[] sprites;
    public int n;

    PlayerData playerData;
    void Start()
    {
        playerData=GameObject.Find("PlayerData").GetComponent<PlayerData>();
        n=Random.Range(0,sprites.Length);
        GetComponent<SpriteRenderer>().sprite=sprites[n];
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            playerData.道具[n]++;
            Destroy(gameObject);

        }
        
    }


}
