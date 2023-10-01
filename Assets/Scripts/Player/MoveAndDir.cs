using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndDir : MonoBehaviour
{
    PlayerData playerData;
    public Vector3 Dir;

 
    int WalkState=0;
    bool Straight=true;
    public Transform Head;
    public Transform Leg;
    public Animator animatorHead;
    public Animator animatorLeg;
    private void Start() 
    {
        Dir=new Vector3(0,-1,0);
        playerData=GameObject.Find("PlayerData").GetComponent<PlayerData>();
    }
    Vector3 PlayerMove()
    {
        Vector3 force = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            force += new Vector3(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            force += new Vector3(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            force += new Vector3(-1, 0, 0);
        }


        if (Input.GetKey(KeyCode.D))
        {
            force += new Vector3(1, 0, 0);
        }
     
        force = force.normalized;
        GetComponent<Rigidbody2D>().AddForce(force*playerData.Speed);
        return force;    
                     
          
    }
    
    void  ChangeSprite()
    {
        if(Dir.x>0&&Dir.y==0)
        {
            WalkState=1;
            Straight=false;
            Head.localScale=new Vector3(2.5f,2.5f,0);
            Leg.localScale=new Vector3(2.5f,2.5f,0);

        }
        else if(Dir.x<0&&Dir.y==0)
        {
            WalkState=1;
            Straight=false;
            Head.localScale=new Vector3(-2.5f,2.5f,0);
            Leg.localScale=new Vector3(-2.5f,2.5f,0);
        }
        else if(Dir.x==0&&Dir.y>0)
        {
            Straight=true;

            WalkState=2;            
        }
        else if(Dir.x==0&&Dir.y<0)
        {
            Straight=true;

            WalkState=0;            
        }
        animatorHead.SetInteger("WalkState",WalkState);
        animatorLeg.SetBool("Straight",Straight);
    }
        
    private void Update()
    {
       Dir= PlayerMove().magnitude==0?Dir:PlayerMove();
       ChangeSprite();
    }
          
      

}




