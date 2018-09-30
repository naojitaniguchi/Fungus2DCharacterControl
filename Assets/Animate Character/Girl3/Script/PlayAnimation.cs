using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour {

  
    public Animator Ani;
    public Sprite[] Spr;
    public SpriteRenderer sprR;
   
    public bool onlySpr = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayAni(string str)
    {
       
        Ani.enabled = true;
        Ani.ForceStateNormalizedTime(0.0f);
        Ani.Play(str);

    }




    public void ChangeSpr(int num)
    {
        if (onlySpr)
        {
            
        }
        else {
           
            Ani.ForceStateNormalizedTime(0.0f);
            Ani.enabled = false;           
        }

        sprR.sprite = Spr[num];
    }

    public void ChangeSpr0()
    {
        sprR.sprite = Spr[0];
    }

    public void ChangeSpr1()
    {
        sprR.sprite = Spr[1];
    }
    public void ChangeSpr2()
    {
        sprR.sprite = Spr[2];
    }
    public void ChangeSpr3()
    {
        sprR.sprite = Spr[3];
    }
    public void ChangeSpr4()
    {
        sprR.sprite = Spr[4];
    }
    public void ChangeSpr5()
    {
        sprR.sprite = Spr[5];
    }
    public void ChangeSpr6()
    {
        sprR.sprite = Spr[6];
    }

}
